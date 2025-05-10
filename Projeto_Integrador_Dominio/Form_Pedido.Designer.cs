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
            labelErro.Location = new Point(160, 503);
            labelErro.Name = "labelErro";
            labelErro.Size = new Size(38, 15);
            labelErro.TabIndex = 0;
            labelErro.Text = "label1";
            // 
            // buttonSelecionar
            // 
            buttonSelecionar.Location = new Point(388, 82);
            buttonSelecionar.Margin = new Padding(3, 2, 3, 2);
            buttonSelecionar.Name = "buttonSelecionar";
            buttonSelecionar.Size = new Size(82, 22);
            buttonSelecionar.TabIndex = 2;
            buttonSelecionar.Text = "Selecionar";
            buttonSelecionar.UseVisualStyleBackColor = true;
            buttonSelecionar.Click += buttonSelecionar_Click;
            // 
            // numericQuantidade
            // 
            numericQuantidade.Location = new Point(87, 394);
            numericQuantidade.Margin = new Padding(3, 2, 3, 2);
            numericQuantidade.Name = "numericQuantidade";
            numericQuantidade.Size = new Size(295, 23);
            numericQuantidade.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 167);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 6;
            label1.Text = "Serviço";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 282);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 7;
            label2.Text = "Produto";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 396);
            label3.Name = "label3";
            label3.Size = new Size(69, 15);
            label3.TabIndex = 8;
            label3.Text = "Quantidade";
            // 
            // BoxBuscCliente
            // 
            BoxBuscCliente.Location = new Point(62, 25);
            BoxBuscCliente.Margin = new Padding(3, 2, 3, 2);
            BoxBuscCliente.Name = "BoxBuscCliente";
            BoxBuscCliente.Size = new Size(320, 23);
            BoxBuscCliente.TabIndex = 9;
            BoxBuscCliente.TextChanged += BoxBuscCliente_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 28);
            label4.Name = "label4";
            label4.Size = new Size(44, 15);
            label4.TabIndex = 10;
            label4.Text = "Cliente";
            // 
            // buttonConPedido
            // 
            buttonConPedido.Location = new Point(803, 421);
            buttonConPedido.Margin = new Padding(3, 2, 3, 2);
            buttonConPedido.Name = "buttonConPedido";
            buttonConPedido.Size = new Size(137, 27);
            buttonConPedido.TabIndex = 11;
            buttonConPedido.Text = "Concluir pedido";
            buttonConPedido.UseVisualStyleBackColor = true;
            buttonConPedido.Click += buttonConPedido_Click;
            // 
            // buttonAdicionarProduto
            // 
            buttonAdicionarProduto.Location = new Point(388, 338);
            buttonAdicionarProduto.Margin = new Padding(3, 2, 3, 2);
            buttonAdicionarProduto.Name = "buttonAdicionarProduto";
            buttonAdicionarProduto.Size = new Size(82, 22);
            buttonAdicionarProduto.TabIndex = 13;
            buttonAdicionarProduto.Text = "Adicionar >";
            buttonAdicionarProduto.UseVisualStyleBackColor = true;
            buttonAdicionarProduto.Click += buttonAdicionarItem_Click;
            // 
            // buttonCancelar
            // 
            buttonCancelar.Location = new Point(868, 546);
            buttonCancelar.Margin = new Padding(3, 2, 3, 2);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(72, 25);
            buttonCancelar.TabIndex = 14;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.UseVisualStyleBackColor = true;
            buttonCancelar.Click += buttonCancelar_Click;
            // 
            // dataGridViewItem
            // 
            dataGridViewItem.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewItem.Location = new Point(476, 73);
            dataGridViewItem.Margin = new Padding(3, 2, 3, 2);
            dataGridViewItem.Name = "dataGridViewItem";
            dataGridViewItem.RowHeadersWidth = 51;
            dataGridViewItem.Size = new Size(464, 344);
            dataGridViewItem.TabIndex = 15;
            // 
            // buttonRemoverItem
            // 
            buttonRemoverItem.Location = new Point(476, 422);
            buttonRemoverItem.Name = "buttonRemoverItem";
            buttonRemoverItem.Size = new Size(82, 23);
            buttonRemoverItem.TabIndex = 19;
            buttonRemoverItem.Text = "Remover";
            buttonRemoverItem.UseVisualStyleBackColor = true;
            buttonRemoverItem.Click += buttonRemoverItem_Click;
            // 
            // dataGridViewCliente
            // 
            dataGridViewCliente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCliente.Location = new Point(12, 52);
            dataGridViewCliente.Margin = new Padding(3, 2, 3, 2);
            dataGridViewCliente.Name = "dataGridViewCliente";
            dataGridViewCliente.RowHeadersWidth = 51;
            dataGridViewCliente.Size = new Size(370, 108);
            dataGridViewCliente.TabIndex = 20;
            // 
            // dataGridViewServico
            // 
            dataGridViewServico.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewServico.Location = new Point(12, 191);
            dataGridViewServico.Margin = new Padding(3, 2, 3, 2);
            dataGridViewServico.Name = "dataGridViewServico";
            dataGridViewServico.RowHeadersWidth = 51;
            dataGridViewServico.Size = new Size(370, 81);
            dataGridViewServico.TabIndex = 21;
            // 
            // dataGridViewProduto
            // 
            dataGridViewProduto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProduto.Location = new Point(12, 309);
            dataGridViewProduto.Margin = new Padding(3, 2, 3, 2);
            dataGridViewProduto.Name = "dataGridViewProduto";
            dataGridViewProduto.RowHeadersWidth = 51;
            dataGridViewProduto.Size = new Size(370, 81);
            dataGridViewProduto.TabIndex = 22;
            // 
            // textBoxProduto
            // 
            textBoxProduto.Location = new Point(68, 279);
            textBoxProduto.Margin = new Padding(3, 2, 3, 2);
            textBoxProduto.Name = "textBoxProduto";
            textBoxProduto.Size = new Size(314, 23);
            textBoxProduto.TabIndex = 23;
            textBoxProduto.TextChanged += textBoxProduto_TextChanged;
            // 
            // textBoxServico
            // 
            textBoxServico.Location = new Point(63, 164);
            textBoxServico.Margin = new Padding(3, 2, 3, 2);
            textBoxServico.Name = "textBoxServico";
            textBoxServico.Size = new Size(319, 23);
            textBoxServico.TabIndex = 24;
            textBoxServico.TextChanged += textBoxServico_TextChanged;
            // 
            // buttonAdicionarServico
            // 
            buttonAdicionarServico.Location = new Point(388, 220);
            buttonAdicionarServico.Margin = new Padding(3, 2, 3, 2);
            buttonAdicionarServico.Name = "buttonAdicionarServico";
            buttonAdicionarServico.Size = new Size(82, 22);
            buttonAdicionarServico.TabIndex = 25;
            buttonAdicionarServico.Text = "Adicionar >";
            buttonAdicionarServico.UseVisualStyleBackColor = true;
            buttonAdicionarServico.Click += buttonAdicionarServico_Click;
            // 
            // labelClienteSelecionado
            // 
            labelClienteSelecionado.AutoSize = true;
            labelClienteSelecionado.Location = new Point(476, 41);
            labelClienteSelecionado.Name = "labelClienteSelecionado";
            labelClienteSelecionado.Size = new Size(113, 15);
            labelClienteSelecionado.TabIndex = 26;
            labelClienteSelecionado.Text = "Cliente selecionado:";
            // 
            // labelValorTotal
            // 
            labelValorTotal.AutoSize = true;
            labelValorTotal.Location = new Point(476, 56);
            labelValorTotal.Name = "labelValorTotal";
            labelValorTotal.Size = new Size(63, 15);
            labelValorTotal.TabIndex = 27;
            labelValorTotal.Text = "Valor total:";
            // 
            // Form_Pedido
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(952, 582);
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
            Margin = new Padding(3, 2, 3, 2);
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
    }
}