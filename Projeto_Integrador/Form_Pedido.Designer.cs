namespace Projeto_Integrador_Dominio
{
    partial class HairSharp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HairSharp));
            labelErro = new Label();
            buttonSelecionar = new Button();
            numericQuantidade = new NumericUpDown();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            BoxBuscCliente = new TextBox();
            label4 = new Label();
            buttonConPedido = new Button();
            buttonAdicionarProduto = new Button();
            buttonCancelar = new Button();
            dataGridViewItem = new DataGridView();
            buttonRemoverItem = new Button();
            dataGridViewCliente = new DataGridView();
            dataGridViewServico = new DataGridView();
            dataGridViewProduto = new DataGridView();
            textBoxProduto = new TextBox();
            textBoxServico = new TextBox();
            buttonAdicionarServico = new Button();
            labelClienteSelecionado = new Label();
            labelValorTotal = new Label();
            textBoxValorTotal = new TextBox();
            comboBoxFormasPagamento = new ComboBox();
            label5 = new Label();
            pictureBox1 = new PictureBox();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)numericQuantidade).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewItem).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCliente).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewServico).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProduto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // labelErro
            // 
            labelErro.AutoSize = true;
            labelErro.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelErro.Location = new Point(739, 470);
            labelErro.Name = "labelErro";
            labelErro.Size = new Size(51, 20);
            labelErro.TabIndex = 0;
            labelErro.Text = "label1";
            // 
            // buttonSelecionar
            // 
            buttonSelecionar.Cursor = Cursors.Hand;
            buttonSelecionar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonSelecionar.Location = new Point(515, 185);
            buttonSelecionar.Name = "buttonSelecionar";
            buttonSelecionar.Size = new Size(94, 38);
            buttonSelecionar.TabIndex = 2;
            buttonSelecionar.Text = "Selecionar";
            buttonSelecionar.UseVisualStyleBackColor = true;
            buttonSelecionar.Click += buttonSelecionar_Click;
            // 
            // numericQuantidade
            // 
            numericQuantidade.Location = new Point(519, 503);
            numericQuantidade.Name = "numericQuantidade";
            numericQuantidade.Size = new Size(43, 27);
            numericQuantidade.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(83, 292);
            label1.Name = "label1";
            label1.Size = new Size(60, 20);
            label1.TabIndex = 6;
            label1.Text = "Serviço";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(83, 467);
            label2.Name = "label2";
            label2.Size = new Size(66, 20);
            label2.TabIndex = 7;
            label2.Text = "Produto";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(519, 470);
            label3.Name = "label3";
            label3.Size = new Size(90, 20);
            label3.TabIndex = 8;
            label3.Text = "Quantidade";
            // 
            // BoxBuscCliente
            // 
            BoxBuscCliente.Cursor = Cursors.IBeam;
            BoxBuscCliente.Location = new Point(140, 102);
            BoxBuscCliente.Name = "BoxBuscCliente";
            BoxBuscCliente.Size = new Size(365, 27);
            BoxBuscCliente.TabIndex = 9;
            BoxBuscCliente.TextChanged += BoxBuscCliente_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(83, 106);
            label4.Name = "label4";
            label4.Size = new Size(57, 20);
            label4.TabIndex = 10;
            label4.Text = "Cliente";
            // 
            // buttonConPedido
            // 
            buttonConPedido.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonConPedido.Location = new Point(878, 522);
            buttonConPedido.Name = "buttonConPedido";
            buttonConPedido.Size = new Size(142, 36);
            buttonConPedido.TabIndex = 11;
            buttonConPedido.Text = "Concluir pedido";
            buttonConPedido.UseVisualStyleBackColor = true;
            buttonConPedido.Click += buttonConPedido_Click;
            // 
            // buttonAdicionarProduto
            // 
            buttonAdicionarProduto.Cursor = Cursors.Hand;
            buttonAdicionarProduto.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonAdicionarProduto.Image = Properties.Resources.icons8_plus_241;
            buttonAdicionarProduto.Location = new Point(512, 536);
            buttonAdicionarProduto.Name = "buttonAdicionarProduto";
            buttonAdicionarProduto.Size = new Size(94, 39);
            buttonAdicionarProduto.TabIndex = 13;
            buttonAdicionarProduto.UseVisualStyleBackColor = true;
            buttonAdicionarProduto.Click += buttonAdicionarItem_Click;
            // 
            // buttonCancelar
            // 
            buttonCancelar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonCancelar.Location = new Point(909, 564);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(81, 33);
            buttonCancelar.TabIndex = 14;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.UseVisualStyleBackColor = true;
            buttonCancelar.Click += buttonCancelar_Click;
            // 
            // dataGridViewItem
            // 
            dataGridViewItem.BackgroundColor = Color.BurlyWood;
            dataGridViewItem.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewItem.Location = new Point(684, 127);
            dataGridViewItem.Name = "dataGridViewItem";
            dataGridViewItem.RowHeadersWidth = 51;
            dataGridViewItem.Size = new Size(530, 266);
            dataGridViewItem.TabIndex = 15;
            // 
            // buttonRemoverItem
            // 
            buttonRemoverItem.Cursor = Cursors.Hand;
            buttonRemoverItem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonRemoverItem.Location = new Point(878, 413);
            buttonRemoverItem.Margin = new Padding(3, 4, 3, 4);
            buttonRemoverItem.Name = "buttonRemoverItem";
            buttonRemoverItem.Size = new Size(142, 36);
            buttonRemoverItem.TabIndex = 19;
            buttonRemoverItem.Text = "Remover Item";
            buttonRemoverItem.UseVisualStyleBackColor = true;
            buttonRemoverItem.Click += buttonRemoverItem_Click;
            // 
            // dataGridViewCliente
            // 
            dataGridViewCliente.BackgroundColor = Color.BurlyWood;
            dataGridViewCliente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCliente.Location = new Point(83, 147);
            dataGridViewCliente.Name = "dataGridViewCliente";
            dataGridViewCliente.RowHeadersWidth = 51;
            dataGridViewCliente.Size = new Size(423, 108);
            dataGridViewCliente.TabIndex = 20;
            // 
            // dataGridViewServico
            // 
            dataGridViewServico.BackgroundColor = Color.BurlyWood;
            dataGridViewServico.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewServico.Location = new Point(83, 324);
            dataGridViewServico.Name = "dataGridViewServico";
            dataGridViewServico.RowHeadersWidth = 51;
            dataGridViewServico.Size = new Size(423, 108);
            dataGridViewServico.TabIndex = 21;
            // 
            // dataGridViewProduto
            // 
            dataGridViewProduto.BackgroundColor = Color.BurlyWood;
            dataGridViewProduto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProduto.Location = new Point(83, 503);
            dataGridViewProduto.Name = "dataGridViewProduto";
            dataGridViewProduto.RowHeadersWidth = 51;
            dataGridViewProduto.Size = new Size(423, 108);
            dataGridViewProduto.TabIndex = 22;
            // 
            // textBoxProduto
            // 
            textBoxProduto.Cursor = Cursors.IBeam;
            textBoxProduto.Location = new Point(147, 463);
            textBoxProduto.Name = "textBoxProduto";
            textBoxProduto.Size = new Size(358, 27);
            textBoxProduto.TabIndex = 23;
            textBoxProduto.TextChanged += textBoxProduto_TextChanged;
            // 
            // textBoxServico
            // 
            textBoxServico.Cursor = Cursors.IBeam;
            textBoxServico.Location = new Point(141, 288);
            textBoxServico.Name = "textBoxServico";
            textBoxServico.Size = new Size(364, 27);
            textBoxServico.TabIndex = 24;
            textBoxServico.TextChanged += textBoxServico_TextChanged;
            // 
            // buttonAdicionarServico
            // 
            buttonAdicionarServico.Cursor = Cursors.Hand;
            buttonAdicionarServico.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonAdicionarServico.Image = Properties.Resources.icons8_plus_24;
            buttonAdicionarServico.Location = new Point(512, 354);
            buttonAdicionarServico.Name = "buttonAdicionarServico";
            buttonAdicionarServico.Size = new Size(94, 39);
            buttonAdicionarServico.TabIndex = 25;
            buttonAdicionarServico.UseVisualStyleBackColor = true;
            buttonAdicionarServico.Click += buttonAdicionarServico_Click;
            // 
            // labelClienteSelecionado
            // 
            labelClienteSelecionado.AutoSize = true;
            labelClienteSelecionado.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelClienteSelecionado.Location = new Point(684, 104);
            labelClienteSelecionado.Name = "labelClienteSelecionado";
            labelClienteSelecionado.Size = new Size(147, 20);
            labelClienteSelecionado.TabIndex = 26;
            labelClienteSelecionado.Text = "Cliente selecionado:";
            // 
            // labelValorTotal
            // 
            labelValorTotal.AutoSize = true;
            labelValorTotal.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelValorTotal.Location = new Point(1220, 185);
            labelValorTotal.Name = "labelValorTotal";
            labelValorTotal.Size = new Size(86, 20);
            labelValorTotal.TabIndex = 27;
            labelValorTotal.Text = "Valor total:";
            // 
            // textBoxValorTotal
            // 
            textBoxValorTotal.Location = new Point(1220, 208);
            textBoxValorTotal.Name = "textBoxValorTotal";
            textBoxValorTotal.ReadOnly = true;
            textBoxValorTotal.Size = new Size(151, 27);
            textBoxValorTotal.TabIndex = 28;
            // 
            // comboBoxFormasPagamento
            // 
            comboBoxFormasPagamento.FormattingEnabled = true;
            comboBoxFormasPagamento.Items.AddRange(new object[] { "Crédito", "Débito", "Pix", "Dinheiro" });
            comboBoxFormasPagamento.Location = new Point(1220, 297);
            comboBoxFormasPagamento.Name = "comboBoxFormasPagamento";
            comboBoxFormasPagamento.Size = new Size(151, 28);
            comboBoxFormasPagamento.TabIndex = 29;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(1220, 274);
            label5.Name = "label5";
            label5.Size = new Size(170, 20);
            label5.TabIndex = 30;
            label5.Text = "Formas de Pagamento:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(557, 510);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(330, 352);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 31;
            pictureBox1.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Elephant", 17.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(551, 39);
            label6.Name = "label6";
            label6.Size = new Size(257, 38);
            label6.TabIndex = 32;
            label6.Text = "Realizar Pedido";
            // 
            // HairSharp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1402, 807);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(comboBoxFormasPagamento);
            Controls.Add(textBoxValorTotal);
            Controls.Add(labelValorTotal);
            Controls.Add(labelClienteSelecionado);
            Controls.Add(buttonAdicionarServico);
            Controls.Add(textBoxServico);
            Controls.Add(textBoxProduto);
            Controls.Add(dataGridViewProduto);
            Controls.Add(dataGridViewServico);
            Controls.Add(dataGridViewCliente);
            Controls.Add(buttonRemoverItem);
            Controls.Add(dataGridViewItem);
            Controls.Add(buttonCancelar);
            Controls.Add(buttonAdicionarProduto);
            Controls.Add(buttonConPedido);
            Controls.Add(label4);
            Controls.Add(BoxBuscCliente);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(numericQuantidade);
            Controls.Add(buttonSelecionar);
            Controls.Add(labelErro);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "HairSharp";
            Text = "HairSharp";
            Load += Form_Pedido_Load;
            ((System.ComponentModel.ISupportInitialize)numericQuantidade).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewItem).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCliente).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewServico).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProduto).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelErro;
        private Button buttonSelecionar;
        private NumericUpDown numericQuantidade;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox BoxBuscCliente;
        private Label label4;
        private Button buttonConPedido;
        private Button buttonAdicionarProduto;
        private Button buttonCancelar;
        private DataGridView dataGridViewItem;
        private Button buttonRemoverItem;
        private DataGridView dataGridViewCliente;
        private DataGridView dataGridViewServico;
        private DataGridView dataGridViewProduto;
        private TextBox textBoxProduto;
        private TextBox textBoxServico;
        private Button buttonAdicionarServico;
        private Label labelClienteSelecionado;
        private Label labelValorTotal;
        private TextBox textBoxValorTotal;
        private ComboBox comboBoxFormasPagamento;
        private Label label5;
        private PictureBox pictureBox1;
        private Label label6;
    }
}