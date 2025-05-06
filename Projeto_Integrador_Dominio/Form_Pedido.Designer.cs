namespace Projeto_Integrador_Dominio
{
    partial class Form_Pedido
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
            labelErro = new Label();
            buttonBuscar = new Button();
            numericQuantidade = new NumericUpDown();
            comboBoxProduto = new ComboBox();
            comboBoxServico = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            BoxBuscCliente = new TextBox();
            label4 = new Label();
            buttonConPedido = new Button();
            buttonAdicionarItem = new Button();
            buttonCancelar = new Button();
            dataGridViewItem = new DataGridView();
            comboBoxPagamento = new ComboBox();
            label5 = new Label();
            checkBoxPagamento = new CheckBox();
            buttonRemoverItem = new Button();
            dataGridViewClientes = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)numericQuantidade).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewItem).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewClientes).BeginInit();
            SuspendLayout();
            // 
            // labelErro
            // 
            labelErro.AutoSize = true;
            labelErro.Location = new Point(29, 474);
            labelErro.Name = "labelErro";
            labelErro.Size = new Size(38, 15);
            labelErro.TabIndex = 0;
            labelErro.Text = "label1";
            // 
            // buttonBuscar
            // 
            buttonBuscar.Location = new Point(267, 38);
            buttonBuscar.Margin = new Padding(3, 2, 3, 2);
            buttonBuscar.Name = "buttonBuscar";
            buttonBuscar.Size = new Size(82, 22);
            buttonBuscar.TabIndex = 2;
            buttonBuscar.Text = "Buscar";
            buttonBuscar.UseVisualStyleBackColor = true;
            buttonBuscar.Click += buttonBuscar_Click;
            // 
            // numericQuantidade
            // 
            numericQuantidade.Location = new Point(178, 286);
            numericQuantidade.Margin = new Padding(3, 2, 3, 2);
            numericQuantidade.Name = "numericQuantidade";
            numericQuantidade.Size = new Size(131, 23);
            numericQuantidade.TabIndex = 3;
            // 
            // comboBoxProduto
            // 
            comboBoxProduto.FormattingEnabled = true;
            comboBoxProduto.Items.AddRange(new object[] { "Shampoo", "Condicionador", "Mascara Hidratacao", "Oleo Revitalizador", "Amarrador", "Maquiagem", "Hidratante Labial" });
            comboBoxProduto.Location = new Point(29, 286);
            comboBoxProduto.Margin = new Padding(3, 2, 3, 2);
            comboBoxProduto.Name = "comboBoxProduto";
            comboBoxProduto.Size = new Size(133, 23);
            comboBoxProduto.TabIndex = 4;
            // 
            // comboBoxServico
            // 
            comboBoxServico.FormattingEnabled = true;
            comboBoxServico.Items.AddRange(new object[] { "Sobrancelha", "Corte", "Escova", "Progressiva", "Hidração", "Luzes", "Tintura" });
            comboBoxServico.Location = new Point(29, 244);
            comboBoxServico.Margin = new Padding(3, 2, 3, 2);
            comboBoxServico.Name = "comboBoxServico";
            comboBoxServico.Size = new Size(133, 23);
            comboBoxServico.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 227);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 6;
            label1.Text = "Serviço";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 269);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 7;
            label2.Text = "Produto";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(178, 269);
            label3.Name = "label3";
            label3.Size = new Size(69, 15);
            label3.TabIndex = 8;
            label3.Text = "Quantidade";
            // 
            // BoxBuscCliente
            // 
            BoxBuscCliente.Location = new Point(31, 38);
            BoxBuscCliente.Margin = new Padding(3, 2, 3, 2);
            BoxBuscCliente.Name = "BoxBuscCliente";
            BoxBuscCliente.Size = new Size(232, 23);
            BoxBuscCliente.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(31, 21);
            label4.Name = "label4";
            label4.Size = new Size(44, 15);
            label4.TabIndex = 10;
            label4.Text = "Cliente";
            // 
            // buttonConPedido
            // 
            buttonConPedido.Location = new Point(635, 252);
            buttonConPedido.Margin = new Padding(3, 2, 3, 2);
            buttonConPedido.Name = "buttonConPedido";
            buttonConPedido.Size = new Size(137, 27);
            buttonConPedido.TabIndex = 11;
            buttonConPedido.Text = "Concluir pedido";
            buttonConPedido.UseVisualStyleBackColor = true;
            buttonConPedido.Click += buttonConPedido_Click;
            // 
            // buttonAdicionarItem
            // 
            buttonAdicionarItem.Location = new Point(132, 399);
            buttonAdicionarItem.Margin = new Padding(3, 2, 3, 2);
            buttonAdicionarItem.Name = "buttonAdicionarItem";
            buttonAdicionarItem.Size = new Size(82, 22);
            buttonAdicionarItem.TabIndex = 13;
            buttonAdicionarItem.Text = "Adicionar";
            buttonAdicionarItem.UseVisualStyleBackColor = true;
            buttonAdicionarItem.Click += buttonAdicionarItem_Click;
            // 
            // buttonCancelar
            // 
            buttonCancelar.Location = new Point(672, 284);
            buttonCancelar.Margin = new Padding(3, 2, 3, 2);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(72, 25);
            buttonCancelar.TabIndex = 14;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.UseVisualStyleBackColor = true;
            // 
            // dataGridViewItem
            // 
            dataGridViewItem.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewItem.Location = new Point(527, 38);
            dataGridViewItem.Margin = new Padding(3, 2, 3, 2);
            dataGridViewItem.Name = "dataGridViewItem";
            dataGridViewItem.RowHeadersWidth = 51;
            dataGridViewItem.Size = new Size(370, 194);
            dataGridViewItem.TabIndex = 15;
            // 
            // comboBoxPagamento
            // 
            comboBoxPagamento.FormattingEnabled = true;
            comboBoxPagamento.Items.AddRange(new object[] { "Crédito", "Débito", "Dinheiro", "Pix" });
            comboBoxPagamento.Location = new Point(29, 361);
            comboBoxPagamento.Margin = new Padding(3, 2, 3, 2);
            comboBoxPagamento.Name = "comboBoxPagamento";
            comboBoxPagamento.Size = new Size(133, 23);
            comboBoxPagamento.TabIndex = 17;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(29, 344);
            label5.Name = "label5";
            label5.Size = new Size(121, 15);
            label5.TabIndex = 16;
            label5.Text = "Forma de Pagamento";
            // 
            // checkBoxPagamento
            // 
            checkBoxPagamento.AutoSize = true;
            checkBoxPagamento.Location = new Point(29, 322);
            checkBoxPagamento.Name = "checkBoxPagamento";
            checkBoxPagamento.Size = new Size(56, 19);
            checkBoxPagamento.TabIndex = 18;
            checkBoxPagamento.Text = "Pagar";
            checkBoxPagamento.UseVisualStyleBackColor = true;
            // 
            // buttonRemoverItem
            // 
            buttonRemoverItem.Location = new Point(132, 426);
            buttonRemoverItem.Name = "buttonRemoverItem";
            buttonRemoverItem.Size = new Size(82, 23);
            buttonRemoverItem.TabIndex = 19;
            buttonRemoverItem.Text = "button1";
            buttonRemoverItem.UseVisualStyleBackColor = true;
            // 
            // dataGridViewClientes
            // 
            dataGridViewClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewClientes.Location = new Point(29, 65);
            dataGridViewClientes.Margin = new Padding(3, 2, 3, 2);
            dataGridViewClientes.Name = "dataGridViewClientes";
            dataGridViewClientes.RowHeadersWidth = 51;
            dataGridViewClientes.Size = new Size(370, 134);
            dataGridViewClientes.TabIndex = 20;
            // 
            // Form_Pedido
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(952, 582);
            Controls.Add(dataGridViewClientes);
            Controls.Add(buttonRemoverItem);
            Controls.Add(checkBoxPagamento);
            Controls.Add(comboBoxPagamento);
            Controls.Add(label5);
            Controls.Add(dataGridViewItem);
            Controls.Add(buttonCancelar);
            Controls.Add(buttonAdicionarItem);
            Controls.Add(buttonConPedido);
            Controls.Add(label4);
            Controls.Add(BoxBuscCliente);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBoxServico);
            Controls.Add(comboBoxProduto);
            Controls.Add(numericQuantidade);
            Controls.Add(buttonBuscar);
            Controls.Add(labelErro);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form_Pedido";
            Text = "Form_Pedido";
            Load += Form_Pedido_Load;
            ((System.ComponentModel.ISupportInitialize)numericQuantidade).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewItem).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelErro;
        private Button buttonBuscar;
        private NumericUpDown numericQuantidade;
        private ComboBox comboBoxProduto;
        private ComboBox comboBoxServico;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox BoxBuscCliente;
        private Label label4;
        private Button buttonConPedido;
        private Button buttonAdicionarItem;
        private Button buttonCancelar;
        private DataGridView dataGridViewItem;
        private ComboBox comboBoxPagamento;
        private Label label5;
        private CheckBox checkBoxPagamento;
        private Button buttonRemoverItem;
        private DataGridView dataGridViewClientes;
    }
}