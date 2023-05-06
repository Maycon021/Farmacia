using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Farmacia
{
    public partial class Vendas : Form
    {
        public Vendas()
        {
            InitializeComponent();
        }
        int numeroVenda = 0;
        int quantidade = 0;
        decimal valor = 0;
        decimal total;

        int estoque;

        

        void carregarGrid()
        {
            SqlConnection conexao = new SqlConnection(Conexao.Conectar());

            string sql = "SELECT * FROM vendas where id = '"+txtNumVenda.Text+"'";

            SqlDataAdapter da = new SqlDataAdapter(sql, conexao);

            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView1.DataSource = dt;
            conexao.Close();
        }


        void carregarAtendente()
        {
            SqlConnection conexao = new SqlConnection(Conexao.Conectar());

            conexao.Open();

            string sql = "SELECT * FROM atendentes WHERE cpf=@cpf";

            SqlCommand comando = new SqlCommand(sql, conexao);
            comando.Parameters.AddWithValue("@cpf", Program.cpf);

            SqlDataReader reader = comando.ExecuteReader();

            reader.Read();

            if (reader.HasRows)
            {
                txtAtendente.Text = reader["nome"].ToString();
            }
            conexao.Close();

        }

        void carregarClientes()
        {
            SqlConnection conexao = new SqlConnection(Conexao.Conectar());

            string sql = "SELECT * FROM clientes";

            conexao.Open();

            SqlDataAdapter da = new SqlDataAdapter(sql, conexao);

            DataTable dt = new DataTable();

            da.Fill(dt);

            cbCliente.DataSource = dt;
            cbCliente.DisplayMember = "nome";
            cbCliente.ValueMember = "id";
            conexao.Close();







        }

        private decimal ValorTotal()
        {
            decimal total = 0;
            int i = 0;
            for (i = 0; i < dataGridView1.Rows.Count; i++)
            {
                total = total + Convert.ToDecimal(dataGridView1.Rows[i].Cells["total"].Value);
            }
            return total;
        }
        private void calculaValorTotalGrid()
        {
            if (dataGridView1.Rows.Count > 0)
                lblTotal.Text = ValorTotal().ToString("c");
        }

        void carregarProdutos()
        {
            SqlConnection conexao = new SqlConnection(Conexao.Conectar());

            string sql = "SELECT * FROM produtos";

            conexao.Open();

            SqlDataAdapter da = new SqlDataAdapter(sql, conexao);

            DataTable dt = new DataTable();

            da.Fill(dt);

            cbProduto.DataSource = dt;
            cbProduto.DisplayMember = "nome";
            cbProduto.ValueMember = "id";

            conexao.Close();







        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {







        }

        private void Vendas_Load(object sender, EventArgs e)
        {
            carregarGrid();
            carregarAtendente();
            carregarClientes();
            carregarProdutos();

            
        }

        private void button3_Click(object sender, EventArgs e)
        {

            
            btnAdicionar.Enabled = true;
            
            btnNovo.Enabled = false;
            lblTotal.Text = "0";


            SqlConnection conexao = new SqlConnection(Conexao.Conectar());
            conexao.Open();
            SqlCommand comando = new SqlCommand("SELECT * FROM vendas", conexao);

            SqlDataReader reader = comando.ExecuteReader();

            

            if (reader.HasRows )
            {

                while (reader.Read())
                {
                    numeroVenda = Convert.ToInt32(reader["id"]) +1;
                    
                }
               




            }
            else
            {
                numeroVenda = 1;
                txtNumVenda.Text = numeroVenda.ToString();
            }
            conexao.Close();
        txtNumVenda.Text = numeroVenda.ToString();
            carregarGrid();
           

        }
        private void btnAdicionar_Click_1(object sender, EventArgs e)
        {
            
            


            SqlConnection conexao = new SqlConnection(Conexao.Conectar());

            conexao.Open();


            quantidade = int.Parse(txtQtd.Text);
            valor = decimal.Parse(txtValorUnit.Text);

            total= quantidade * valor;




            int verificaEstoque = int.Parse(txtEstoque.Text) - int.Parse(txtQtd.Text);



            if(verificaEstoque  < 0 )
            {
                MessageBox.Show("Não há estoque disponivel, por favor repor estoque!!");
            }
            else
            {


                if(txtQtd.Text != "" && cbPagamento.Text != "")
                {

               
                btnFinalizar.Enabled = true;
          
            
            string sql = "INSERT INTO vendas (id,atendenteid, clienteid,produtoid,total,quantidade,datacad,pagamento,situacao) VALUES (@id,@atendenteid,@clienteid,@produtoid,@total,@quantidade,@datacad,@pagamento,@situacao)";



            SqlCommand comando = new SqlCommand(sql, conexao);
            comando.Parameters.AddWithValue("@id", int.Parse(txtNumVenda.Text));
            comando.Parameters.AddWithValue("@atendenteid",Program.id);
            comando.Parameters.AddWithValue("@clienteid", cbCliente.SelectedValue);
            comando.Parameters.AddWithValue("@produtoid", cbProduto.SelectedValue);
            comando.Parameters.AddWithValue("@total", total);
            comando.Parameters.AddWithValue("@quantidade", txtQtd.Text );
            comando.Parameters.AddWithValue("@datacad", DateTime.Now);
            comando.Parameters.AddWithValue("@pagamento", cbPagamento.Text);
            comando.Parameters.AddWithValue("@situacao", "Vendido");
            comando.ExecuteNonQuery();
            conexao.Close();



            //ATUALIZA O ESTOQUE DE PRODUTOS



            SqlConnection conexao2 = new SqlConnection(Conexao.Conectar());

            conexao2.Open();
            string sql2 = "UPDATE produtos SET estoque=@estoque WHERE nome = '"+cbProduto.Text+"'";

           




                int baixaEstoque = Convert.ToInt32(txtEstoque.Text) - Convert.ToInt32(txtQtd.Text);


            SqlCommand comando2 = new SqlCommand(sql2, conexao2);
           
                comando2.Parameters.AddWithValue("@estoque",baixaEstoque );

                comando2.ExecuteNonQuery();

            conexao2.Close();

            

            txtEstoque.Text = baixaEstoque.ToString();



            carregarGrid();
                }

                else
                {
                    MessageBox.Show("Preencha todos os campos");
                }

            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            btnAdicionar.Enabled = false;
            btnFinalizar.Enabled = false;
            btnNovo.Enabled = true;
            calculaValorTotalGrid();

        }




        private void cbProduto_SelectedIndexChanged(object sender, EventArgs e)
        {

            SqlConnection conexao = new SqlConnection(Conexao.Conectar());

            string sql = "SELECT * FROM produtos where nome = @nome";

            conexao.Open();

            SqlCommand comando = new SqlCommand(sql, conexao);
            comando.Parameters.AddWithValue("@nome", cbProduto.Text);



            SqlDataReader dr = comando.ExecuteReader();

            dr.Read();

            if (dr.HasRows)
            {

                estoque = (int)dr["estoque"];
                txtValorUnit.Text = dr["preco"].ToString();

               



            }

            conexao.Close();

            txtEstoque.Text = estoque.ToString();


        }

        private void cbProduto_SelectedValueChanged(object sender, EventArgs e)
        {
            
        }

        private void txtValor_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
