namespace Farmacia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Fornecedores novo = new Fornecedores();
            novo.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Categorias novo = new Categorias();
            novo.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Produtos novo = new Produtos();
            novo.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Atendentes novo = new Atendentes();
            novo.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblUsuario.Text = Program.usuario + "(" +Program.nivel+ ")";
           

            if (Program.nivel != "Administrador")
            {
                btnUsuarios.Enabled = false;
            }

          

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Clientes novo = new Clientes();
            novo.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Vendas novo = new Vendas();
            novo.ShowDialog();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Clientes novo = new Clientes();
            novo.ShowDialog();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Categorias novo = new Categorias();
            novo.ShowDialog();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            Fornecedores novo = new Fornecedores();
            novo.ShowDialog();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            Atendentes novo = new Atendentes();
            novo.ShowDialog();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            Produtos novo = new Produtos();
            novo.ShowDialog();
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            Vendas novo = new Vendas();
            novo.ShowDialog();
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
        }

        private void lblUsuario_Click(object sender, EventArgs e)
        {

        }
    }
}