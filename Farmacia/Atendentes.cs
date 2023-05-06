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
    public partial class Atendentes : Form
    {
        public Atendentes()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conexao = new SqlConnection(Conexao.Conectar());

            conexao.Open();

            string sql = "INSERT INTO atendentes (nome,nascimento,endereco,cep,bairro,cpf,email,datacad) VALUES (@nome,@nascimento,@endereco,@cep,@bairro,@cpf,@email,@datacad)";


            SqlCommand comando = new SqlCommand(sql, conexao);
            comando.Parameters.AddWithValue("@nome", txtNome.Text);
            comando.Parameters.AddWithValue("@nascimento", txtNascimento.Text);
            comando.Parameters.AddWithValue("@endereco", txtEndereco.Text);
            comando.Parameters.AddWithValue("@cep", txtCep.Text);
            comando.Parameters.AddWithValue("@bairro", txtBairro.Text);
            comando.Parameters.AddWithValue("@cpf", txtCpf.Text);
            comando.Parameters.AddWithValue("@email", txtEmail.Text);
            comando.Parameters.AddWithValue("@datacad", DateTime.Now);
            comando.ExecuteNonQuery();
           



            string sql2 = "INSERT INTO loguin (senha,nivel,situacao,cpf,usuario) VALUES (@senha,@nivel,@situacao,@cpf,@usuario)";


            SqlCommand comando2 = new SqlCommand(sql2, conexao);
            comando2.Parameters.AddWithValue("@usuario", txtEmail.Text);
            comando2.Parameters.AddWithValue("@senha", txtCpf.Text);
            comando2.Parameters.AddWithValue("@nivel", "Atendente");
            comando2.Parameters.AddWithValue("@situacao", "Ativo");
            comando2.Parameters.AddWithValue("@cpf", txtCpf.Text);
            comando2.ExecuteNonQuery();
            conexao.Close();
           

            MessageBox.Show("Atendente cadastrado com sucesso!");





        }
    }
}
