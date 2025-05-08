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
            buttonSelecionar = new Button();
            numericQuantidade = new NumericUpDown();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            BoxBuscCliente = new TextBox();
            label4 = new Label();
            buttonConPedido = new Button();
            buttonAdicionarItem = new Button();
            buttonCancelar = new Button();
            dataGridViewItem = new DataGridView();
            buttonRemoverItem = new Button();
            dataGridViewCliente = new DataGridView();
            dataGridViewServico = new DataGridView();
            dataGridViewProduto = new DataGridView();
            textBoxProduto = new TextBox();
            textBoxServico = new TextBox();
            ((System.ComponentModel.ISupportInitialize)numericQuantidade).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewItem).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCliente).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewServico).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProduto).BeginInit();
            SuspendLayout();
            // 
            // labelErro
            // 
            labelErro.AutoSize = true;
            labelErro.Location = new Point(602, 600);
            labelErro.Name = "labelErro";
            labelErro.Size = new Size(50, 20);
            labelErro.TabIndex = 0;
            labelErro.Text = "label1";
            // 
            // buttonSelecionar
            // 
            buttonSelecionar.Location = new Point(305, 51);
            buttonSelecionar.Name = "buttonSelecionar";
            buttonSelecionar.Size = new Size(94, 29);
            buttonSelecionar.TabIndex = 2;
            buttonSelecionar.Text = "Selecionar";
            buttonSelecionar.UseVisualStyleBackColor = true;
            buttonSelecionar.Click += buttonSelecionar_Click;
            // 
            // numericQuantidade
            // 
            numericQuantidade.Location = new Point(203, 455);
            numericQuantidade.Name = "numericQuantidade";
            numericQuantidade.Size = new Size(150, 27);
            numericQuantidade.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 245);
            label1.Name = "label1";
            label1.Size = new Size(57, 20);
            label1.TabIndex = 6;
            label1.Text = "Serviço";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 432);
            label2.Name = "label2";
            label2.Size = new Size(62, 20);
            label2.TabIndex = 7;
            label2.Text = "Produto";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(203, 432);
            label3.Name = "label3";
            label3.Size = new Size(87, 20);
            label3.TabIndex = 8;
            label3.Text = "Quantidade";
            // 
            // BoxBuscCliente
            // 
            BoxBuscCliente.Location = new Point(35, 51);
            BoxBuscCliente.Name = "BoxBuscCliente";
            BoxBuscCliente.Size = new Size(265, 27);
            BoxBuscCliente.TabIndex = 9;
            BoxBuscCliente.TextChanged += BoxBuscCliente_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(35, 28);
            label4.Name = "label4";
            label4.Size = new Size(55, 20);
            label4.TabIndex = 10;
            label4.Text = "Cliente";
            // 
            // buttonConPedido
            // 
            buttonConPedido.Location = new Point(726, 336);
            buttonConPedido.Name = "buttonConPedido";
            buttonConPedido.Size = new Size(157, 36);
            buttonConPedido.TabIndex = 11;
            buttonConPedido.Text = "Concluir pedido";
            buttonConPedido.UseVisualStyleBackColor = true;
            buttonConPedido.Click += buttonConPedido_Click;
            // 
            // buttonAdicionarItem
            // 
            buttonAdicionarItem.Location = new Point(151, 628);
            buttonAdicionarItem.Name = "buttonAdicionarItem";
            buttonAdicionarItem.Size = new Size(94, 29);
            buttonAdicionarItem.TabIndex = 13;
            buttonAdicionarItem.Text = "Adicionar";
            buttonAdicionarItem.UseVisualStyleBackColor = true;
            buttonAdicionarItem.Click += buttonAdicionarItem_Click;
            // 
            // buttonCancelar
            // 
            buttonCancelar.Location = new Point(768, 379);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(82, 33);
            buttonCancelar.TabIndex = 14;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.UseVisualStyleBackColor = true;
            // 
            // dataGridViewItem
            // 
            dataGridViewItem.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewItem.Location = new Point(602, 51);
            dataGridViewItem.Name = "dataGridViewItem";
            dataGridViewItem.RowHeadersWidth = 51;
            dataGridViewItem.Size = new Size(423, 259);
            dataGridViewItem.TabIndex = 15;
            // 
            // buttonRemoverItem
            // 
            buttonRemoverItem.Location = new Point(151, 664);
            buttonRemoverItem.Margin = new Padding(3, 4, 3, 4);
            buttonRemoverItem.Name = "buttonRemoverItem";
            buttonRemoverItem.Size = new Size(94, 31);
            buttonRemoverItem.TabIndex = 19;
            buttonRemoverItem.Text = "Remover";
            buttonRemoverItem.UseVisualStyleBackColor = true;
            // 
            // dataGridViewCliente
            // 
            dataGridViewCliente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCliente.Location = new Point(33, 87);
            dataGridViewCliente.Name = "dataGridViewCliente";
            dataGridViewCliente.RowHeadersWidth = 51;
            dataGridViewCliente.Size = new Size(423, 144);
            dataGridViewCliente.TabIndex = 20;
            // 
            // dataGridViewServico
            // 
            dataGridViewServico.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewServico.Location = new Point(33, 304);
            dataGridViewServico.Name = "dataGridViewServico";
            dataGridViewServico.RowHeadersWidth = 51;
            dataGridViewServico.Size = new Size(423, 108);
            dataGridViewServico.TabIndex = 21;
            // 
            // dataGridViewProduto
            // 
            dataGridViewProduto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProduto.Location = new Point(33, 491);
            dataGridViewProduto.Name = "dataGridViewProduto";
            dataGridViewProduto.RowHeadersWidth = 51;
            dataGridViewProduto.Size = new Size(423, 108);
            dataGridViewProduto.TabIndex = 22;
            // 
            // textBoxProduto
            // 
            textBoxProduto.Location = new Point(33, 455);
            textBoxProduto.Name = "textBoxProduto";
            textBoxProduto.Size = new Size(150, 27);
            textBoxProduto.TabIndex = 23;
            textBoxProduto.TextChanged += textBoxProduto_TextChanged;
            // 
            // textBoxServico
            // 
            textBoxServico.Location = new Point(35, 271);
            textBoxServico.Name = "textBoxServico";
            textBoxServico.Size = new Size(148, 27);
            textBoxServico.TabIndex = 24;
            textBoxServico.TextChanged += textBoxServico_TextChanged;
            // 
            // Form_Pedido
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1088, 776);
            Controls.Add(textBoxServico);
            Controls.Add(textBoxProduto);
            Controls.Add(dataGridViewProduto);
            Controls.Add(dataGridViewServico);
            Controls.Add(dataGridViewCliente);
            Controls.Add(buttonRemoverItem);
            Controls.Add(dataGridViewItem);
            Controls.Add(buttonCancelar);
            Controls.Add(buttonAdicionarItem);
            Controls.Add(buttonConPedido);
            Controls.Add(label4);
            Controls.Add(BoxBuscCliente);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(numericQuantidade);
            Controls.Add(buttonSelecionar);
            Controls.Add(labelErro);
            Name = "Form_Pedido";
            Text = "Form_Pedido";
            Load += Form_Pedido_Load;
            ((System.ComponentModel.ISupportInitialize)numericQuantidade).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewItem).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCliente).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewServico).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProduto).EndInit();
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
        private Button buttonAdicionarItem;
        private Button buttonCancelar;
        private DataGridView dataGridViewItem;
        private Button buttonRemoverItem;
        private DataGridView dataGridViewCliente;
        private DataGridView dataGridViewServico;
        private DataGridView dataGridViewProduto;
        private TextBox textBoxProduto;
        private TextBox textBoxServico;
    }
}