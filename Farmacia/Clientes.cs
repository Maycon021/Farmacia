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
    public partial class Clientes : Form
    {
        public Clientes()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conexao = new SqlConnection(Conexao.Conectar());

            conexao.Open();

            string sql = "INSERT INTO clientes (nome,nascimento,endereco,cep,bairro,cpf,email,datacad) VALUES(@nome,@nascimento,@endereco,@cep,@bairro,@cpf,@email,@datacad)";

            SqlCommand comando = new SqlCommand(sql, conexao);

            comando.Parameters.AddWithValue("@nome", txtNome.Text);
            comando.Parameters.AddWithValue("@nascimento", mskNascimento.Text);
            comando.Parameters.AddWithValue("@endereco", txtEndereco.Text);
            comando.Parameters.AddWithValue("@cep", txtCep.Text);
            comando.Parameters.AddWithValue("@bairro", txtBairro.Text);
            comando.Parameters.AddWithValue("@cpf", txtCpf.Text);
            comando.Parameters.AddWithValue("@email", txtEmail.Text);
            comando.Parameters.AddWithValue("@datacad", DateTime.Now);

            comando.ExecuteNonQuery();

            MessageBox.Show("Cliente cadastrado com sucesso!");


        }

        private void txtEndereco_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCpf_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBairro_TextChanged(object sender, EventArgs e)
        {

        }

        private void mskNascimento_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtCep_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void Clientes_Load(object sender, EventArgs e)
        {

        }
    }
}
