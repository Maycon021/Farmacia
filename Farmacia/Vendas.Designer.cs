namespace Farmacia
{
    partial class Vendas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtAtendente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbCliente = new System.Windows.Forms.ComboBox();
            this.cbProduto = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtQtd = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEstoque = new System.Windows.Forms.TextBox();
            this.cbPagamento = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.txtNumVenda = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtValorUnit = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtAtendente
            // 
            this.txtAtendente.Enabled = false;
            this.txtAtendente.Location = new System.Drawing.Point(82, 88);
            this.txtAtendente.Name = "txtAtendente";
            this.txtAtendente.Size = new System.Drawing.Size(166, 23);
            this.txtAtendente.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Atendente:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(264, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Clientes:";
            // 
            // cbCliente
            // 
            this.cbCliente.FormattingEnabled = true;
            this.cbCliente.Location = new System.Drawing.Point(322, 93);
            this.cbCliente.Name = "cbCliente";
            this.cbCliente.Size = new System.Drawing.Size(121, 23);
            this.cbCliente.TabIndex = 4;
            // 
            // cbProduto
            // 
            this.cbProduto.FormattingEnabled = true;
            this.cbProduto.Items.AddRange(new object[] {
            "selecione um produto"});
            this.cbProduto.Location = new System.Drawing.Point(520, 93);
            this.cbProduto.Name = "cbProduto";
            this.cbProduto.Size = new System.Drawing.Size(121, 23);
            this.cbProduto.TabIndex = 6;
            this.cbProduto.SelectedIndexChanged += new System.EventHandler(this.cbProduto_SelectedIndexChanged);
            this.cbProduto.SelectedValueChanged += new System.EventHandler(this.cbProduto_SelectedValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(461, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Produto:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Qtd:";
            // 
            // txtQtd
            // 
            this.txtQtd.Location = new System.Drawing.Point(43, 137);
            this.txtQtd.Name = "txtQtd";
            this.txtQtd.Size = new System.Drawing.Size(70, 23);
            this.txtQtd.TabIndex = 7;
            this.txtQtd.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(341, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "Estoque:";
            // 
            // txtEstoque
            // 
            this.txtEstoque.Enabled = false;
            this.txtEstoque.Location = new System.Drawing.Point(399, 137);
            this.txtEstoque.Name = "txtEstoque";
            this.txtEstoque.Size = new System.Drawing.Size(100, 23);
            this.txtEstoque.TabIndex = 11;
            // 
            // cbPagamento
            // 
            this.cbPagamento.FormattingEnabled = true;
            this.cbPagamento.Items.AddRange(new object[] {
            "Cartão de credito",
            "Pix",
            "Debito"});
            this.cbPagamento.Location = new System.Drawing.Point(197, 184);
            this.cbPagamento.Name = "cbPagamento";
            this.cbPagamento.Size = new System.Drawing.Size(282, 23);
            this.cbPagamento.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(47, 187);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 15);
            this.label7.TabIndex = 13;
            this.label7.Text = "Forma de pagamento:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(23, 225);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(635, 185);
            this.dataGridView1.TabIndex = 15;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Enabled = false;
            this.btnAdicionar.Location = new System.Drawing.Point(197, 438);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(148, 73);
            this.btnAdicionar.TabIndex = 16;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click_1);
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Enabled = false;
            this.btnFinalizar.Location = new System.Drawing.Point(351, 438);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(148, 73);
            this.btnFinalizar.TabIndex = 17;
            this.btnFinalizar.Text = "Finalizar venda";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            this.btnFinalizar.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(43, 438);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(148, 73);
            this.btnNovo.TabIndex = 18;
            this.btnNovo.Text = "Nova";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtNumVenda
            // 
            this.txtNumVenda.Enabled = false;
            this.txtNumVenda.Location = new System.Drawing.Point(82, 50);
            this.txtNumVenda.Name = "txtNumVenda";
            this.txtNumVenda.Size = new System.Drawing.Size(100, 23);
            this.txtNumVenda.TabIndex = 19;
            this.txtNumVenda.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(33, 53);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 15);
            this.label8.TabIndex = 20;
            this.label8.Text = "Venda:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(547, 479);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 15);
            this.label9.TabIndex = 21;
            this.label9.Text = "Total:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(590, 479);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(13, 15);
            this.lblTotal.TabIndex = 22;
            this.lblTotal.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(137, 140);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 15);
            this.label11.TabIndex = 24;
            this.label11.Text = "Valor unitario";
            // 
            // txtValorUnit
            // 
            this.txtValorUnit.Enabled = false;
            this.txtValorUnit.Location = new System.Drawing.Point(221, 137);
            this.txtValorUnit.Name = "txtValorUnit";
            this.txtValorUnit.Size = new System.Drawing.Size(98, 23);
            this.txtValorUnit.TabIndex = 23;
            this.txtValorUnit.Text = "0";
            // 
            // Vendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 556);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtValorUnit);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtNumVenda);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cbPagamento);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtEstoque);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtQtd);
            this.Controls.Add(this.cbProduto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbCliente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAtendente);
            this.Name = "Vendas";
            this.Text = "Vendas";
            this.Load += new System.EventHandler(this.Vendas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtAtendente;
        private Label label1;
        private Label label2;
        private ComboBox cbCliente;
        private ComboBox cbProduto;
        private Label label3;
        private Label label4;
        private TextBox txtQtd;
        private Label label6;
        private TextBox txtEstoque;
        private ComboBox cbPagamento;
        private Label label7;
        private DataGridView dataGridView1;
        private Button btnAdicionar;
        private Button btnFinalizar;
        private Button btnNovo;
        private TextBox txtNumVenda;
        private Label label8;
        private Label label9;
        private Label lblTotal;
        private Label label11;
        private TextBox txtValorUnit;
    }
}