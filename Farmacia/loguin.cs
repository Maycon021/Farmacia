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
    public partial class loguin : Form
    {
        public loguin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conexao = new SqlConnection(Conexao.Conectar());

            conexao.Open();
            string sql = "SELECT * FROM loguin WHERE usuario = '" + txtUsuario.Text + "' AND senha= '" + txtSenha.Text + "' ";

            SqlCommand comando = new SqlCommand(sql, conexao);

            SqlDataReader reader = comando.ExecuteReader();

            reader.Read();

            if( reader.HasRows )
            {
                Program.nivel = reader["nivel"].ToString();
                Program.usuario = reader["usuario"].ToString();
                Program.cpf = reader["cpf"].ToString();
                Program.id = Convert.ToInt32(reader["id"]);
                Form1 novo = new Form1();
                novo.ShowDialog();
               
                this.Hide();

             

            }
            else
            {
                MessageBox.Show("Usuario ou senha estão incorretos!");
            }
        }
    }
}
