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
            comboBoxServiço = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            BoxBuscCliente = new TextBox();
            label4 = new Label();
            buttonConPedido = new Button();
            ((System.ComponentModel.ISupportInitialize)numericQuantidade).BeginInit();
            SuspendLayout();
            // 
            // labelErro
            // 
            labelErro.AutoSize = true;
            labelErro.Location = new Point(23, 412);
            labelErro.Name = "labelErro";
            labelErro.Size = new Size(50, 20);
            labelErro.TabIndex = 0;
            labelErro.Text = "label1";
            // 
            // buttonBuscar
            // 
            buttonBuscar.Location = new Point(305, 51);
            buttonBuscar.Name = "buttonBuscar";
            buttonBuscar.Size = new Size(94, 29);
            buttonBuscar.TabIndex = 2;
            buttonBuscar.Text = "Buscar";
            buttonBuscar.UseVisualStyleBackColor = true;
            buttonBuscar.Click += buttonBuscar_Click;
            // 
            // numericQuantidade
            // 
            numericQuantidade.Location = new Point(203, 284);
            numericQuantidade.Name = "numericQuantidade";
            numericQuantidade.Size = new Size(150, 27);
            numericQuantidade.TabIndex = 3;
            // 
            // comboBoxProduto
            // 
            comboBoxProduto.FormattingEnabled = true;
            comboBoxProduto.Location = new Point(35, 283);
            comboBoxProduto.Name = "comboBoxProduto";
            comboBoxProduto.Size = new Size(151, 28);
            comboBoxProduto.TabIndex = 4;
            // 
            // comboBoxServiço
            // 
            comboBoxServiço.FormattingEnabled = true;
            comboBoxServiço.Location = new Point(35, 212);
            comboBoxServiço.Name = "comboBoxServiço";
            comboBoxServiço.Size = new Size(151, 28);
            comboBoxServiço.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 189);
            label1.Name = "label1";
            label1.Size = new Size(57, 20);
            label1.TabIndex = 6;
            label1.Text = "Serviço";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 260);
            label2.Name = "label2";
            label2.Size = new Size(62, 20);
            label2.TabIndex = 7;
            label2.Text = "Produto";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(203, 260);
            label3.Name = "label3";
            label3.Size = new Size(87, 20);
            label3.TabIndex = 8;
            label3.Text = "Quantidade";
            // 
            // BoxBuscCliente
            // 
            BoxBuscCliente.Location = new Point(35, 51);
            BoxBuscCliente.Name = "BoxBuscCliente";
            BoxBuscCliente.Size = new Size(264, 27);
            BoxBuscCliente.TabIndex = 9;
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
            buttonConPedido.Location = new Point(113, 333);
            buttonConPedido.Name = "buttonConPedido";
            buttonConPedido.Size = new Size(177, 36);
            buttonConPedido.TabIndex = 11;
            buttonConPedido.Text = "Concluir pedido";
            buttonConPedido.UseVisualStyleBackColor = true;
            buttonConPedido.Click += buttonConPedido_Click;
            // 
            // Form_Pedido
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonConPedido);
            Controls.Add(label4);
            Controls.Add(BoxBuscCliente);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBoxServiço);
            Controls.Add(comboBoxProduto);
            Controls.Add(numericQuantidade);
            Controls.Add(buttonBuscar);
            Controls.Add(labelErro);
            Name = "Form_Pedido";
            Text = "Form_Pedido";
            Load += Form_Pedido_Load;
            ((System.ComponentModel.ISupportInitialize)numericQuantidade).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelErro;
        private Button buttonBuscar;
        private NumericUpDown numericQuantidade;
        private ComboBox comboBoxProduto;
        private ComboBox comboBoxServiço;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox BoxBuscCliente;
        private Label label4;
        private Button buttonConPedido;
    }
}