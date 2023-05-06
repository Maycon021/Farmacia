using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Farmacia
{
    public partial class Produtos : Form
    {
        public Produtos()
        {
            InitializeComponent();
        }


        Bitmap bmp;


        void CarregarCategoria()
        {

            SqlConnection conexao = new SqlConnection(Conexao.Conectar());

            conexao.Open();

            string sql = "SELECT * FROM categorias";


            SqlDataAdapter da = new SqlDataAdapter(sql, conexao);

            DataTable dt = new DataTable();

            da.Fill(dt);

            cbCategoria.DataSource = dt;
            
            cbCategoria.DisplayMember = "nome";
            cbCategoria.ValueMember = "id";
           

          

        }

        void CarregarFornecedor()
        {

            SqlConnection conexao = new SqlConnection(Conexao.Conectar());

            conexao.Open();

            string sql = "SELECT * FROM fornecedores";


            SqlDataAdapter da = new SqlDataAdapter(sql, conexao);

            DataTable dt = new DataTable();

            da.Fill(dt);

            cbFornecedor.DataSource = dt;

            cbFornecedor.DisplayMember = "nome";
            cbFornecedor.ValueMember = "id";




        }

        void CarregarGrid()
        {

            SqlConnection conexao = new SqlConnection(Conexao.Conectar());

            conexao.Open();

            string sql = "SELECT * FROM produtos";


            SqlDataAdapter da = new SqlDataAdapter(sql, conexao);

            DataTable dt = new DataTable();

            da.Fill(dt);

           

            dataGridView1.DataSource = dt;



        }


        private void Produtos_Load(object sender, EventArgs e)
        {
            CarregarCategoria();
            CarregarFornecedor();
            CarregarGrid();

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            
        }

        private void btnImagem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // nome do arquivo selecionado
                string nome = openFileDialog1.FileName;
               // txtCaminho.Text = nome;
                bmp = new Bitmap(nome);
                pictureBox1.Image = bmp;

                //inseriu = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            MemoryStream memory = new MemoryStream();
            bmp.Save(memory, ImageFormat.Bmp);

            byte[] foto = memory.ToArray();

            SqlConnection conexao = new SqlConnection(Conexao.Conectar());

            conexao.Open();

            string sql = "INSERT INTO produtos (idfornecedor,idcategoria,nome,marca,preco,estoque,validade,imagem,datacad) VALUES (@idfornecedor,@idcategoria,@nome,@marca,@preco,@estoque,@validade,@imagem,@datacad)";

            SqlCommand comando = new SqlCommand(sql , conexao);

            comando.Parameters.AddWithValue("@idfornecedor", cbFornecedor.SelectedValue);
            comando.Parameters.AddWithValue("@idcategoria", cbCategoria.SelectedValue);
            comando.Parameters.AddWithValue("@nome", txtProduto.Text);
            comando.Parameters.AddWithValue("@marca", txtMarca.Text);
            comando.Parameters.AddWithValue("@preco", txtValor.Text);
            comando.Parameters.AddWithValue("@estoque", txtEstoque.Text);
            comando.Parameters.AddWithValue("@validade", mskValidade.Text);
            comando.Parameters.AddWithValue("@imagem", foto);
            comando.Parameters.AddWithValue("@datacad", DateTime.Now);

            comando.ExecuteNonQuery();

            MessageBox.Show("Produto cadastrado com sucesso!");

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            SqlConnection conexao = new SqlConnection(Conexao.Conectar());

            conexao.Open();

            SqlCommand comando = new SqlCommand("SELECT * FROM produtos WHERE nome=@nome", conexao);
            comando.Parameters.AddWithValue("@nome", txtPesquisar.Text);

            SqlDataReader reader = comando.ExecuteReader();

             reader.Read();


            if (reader.HasRows)
            {
                cbFornecedor.SelectedIndex = (int)reader["idfornecedor"] -1;
                cbCategoria.SelectedIndex =  (int)reader["idcategoria"]-1 ;
                txtProduto.Text = reader["nome"].ToString();
                txtMarca.Text = reader["marca"].ToString();
                txtValor.Text = reader["preco"].ToString();
                txtEstoque.Text = reader["estoque"].ToString();
                mskValidade.Text = reader["validade"].ToString();

                byte[] imagem = (byte[])reader["imagem"];

                if(imagem == null)
                {
                    pictureBox1.Image = null;
                }
                else
                {
                    MemoryStream memory = new MemoryStream(imagem);
                    pictureBox1.Image = Image.FromStream(memory);
                }
                conexao.Close();





            }




        }
    }
}
