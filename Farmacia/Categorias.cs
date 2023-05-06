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
    public partial class Categorias : Form
    {
        public Categorias()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conexao = new SqlConnection(Conexao.Conectar());

            conexao.Open();

            string sql = "INSERT INTO categorias (nome,descricao) VALUES (@nome,@descricao) ";

            SqlCommand comando = new SqlCommand(sql, conexao);
            comando.Parameters.AddWithValue("@nome", txtNome.Text);
            comando.Parameters.AddWithValue("@descricao", txtDescricao.Text);
           
            comando.ExecuteNonQuery();

            MessageBox.Show("Cadastrado com sucesso!");
        }

        private void Categorias_Load(object sender, EventArgs e)
        {

        }
    }
}
