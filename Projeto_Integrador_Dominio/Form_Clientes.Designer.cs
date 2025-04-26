namespace Projeto_Integrador_Dominio
{
    partial class Form_Clientes
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            maskedBoxTel = new MaskedTextBox();
            maskedBoxCPF = new MaskedTextBox();
            textBoxNome = new TextBox();
            textBoxEmail = new TextBox();
            buttonCadastrar = new Button();
            label1 = new Label();
            labelErro = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            dataGridViewClientes = new DataGridView();
            buttonPedidos = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewClientes).BeginInit();
            SuspendLayout();
            // 
            // maskedBoxTel
            // 
            maskedBoxTel.Location = new Point(131, 181);
            maskedBoxTel.Mask = "(00)00000-0000";
            maskedBoxTel.Name = "maskedBoxTel";
            maskedBoxTel.Size = new Size(101, 23);
            maskedBoxTel.TabIndex = 0;
            // 
            // maskedBoxCPF
            // 
            maskedBoxCPF.Location = new Point(132, 237);
            maskedBoxCPF.Mask = "000.000.000-00";
            maskedBoxCPF.Name = "maskedBoxCPF";
            maskedBoxCPF.Size = new Size(100, 23);
            maskedBoxCPF.TabIndex = 1;
            // 
            // textBoxNome
            // 
            textBoxNome.Location = new Point(132, 68);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(100, 23);
            textBoxNome.TabIndex = 2;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(132, 121);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(100, 23);
            textBoxEmail.TabIndex = 3;
            // 
            // buttonCadastrar
            // 
            buttonCadastrar.Location = new Point(132, 285);
            buttonCadastrar.Name = "buttonCadastrar";
            buttonCadastrar.Size = new Size(100, 30);
            buttonCadastrar.TabIndex = 4;
            buttonCadastrar.Text = "Cadastrar";
            buttonCadastrar.UseVisualStyleBackColor = true;
            buttonCadastrar.Click += buttonCadastrar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(132, 219);
            label1.Name = "label1";
            label1.Size = new Size(28, 15);
            label1.TabIndex = 5;
            label1.Text = "CPF";
            // 
            // labelErro
            // 
            labelErro.AutoSize = true;
            labelErro.Location = new Point(131, 386);
            labelErro.Name = "labelErro";
            labelErro.Size = new Size(38, 15);
            labelErro.TabIndex = 6;
            labelErro.Text = "label2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(131, 163);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 7;
            label3.Text = "Telefone";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(132, 103);
            label4.Name = "label4";
            label4.Size = new Size(41, 15);
            label4.TabIndex = 8;
            label4.Text = "E-mail";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(132, 50);
            label5.Name = "label5";
            label5.Size = new Size(40, 15);
            label5.TabIndex = 9;
            label5.Text = "Nome";
            // 
            // dataGridViewClientes
            // 
            dataGridViewClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewClientes.Location = new Point(311, 68);
            dataGridViewClientes.Name = "dataGridViewClientes";
            dataGridViewClientes.Size = new Size(415, 268);
            dataGridViewClientes.TabIndex = 10;
            // 
            // buttonPedidos
            // 
            buttonPedidos.Location = new Point(131, 332);
            buttonPedidos.Name = "buttonPedidos";
            buttonPedidos.Size = new Size(100, 30);
            buttonPedidos.TabIndex = 11;
            buttonPedidos.Text = "Pedidos";
            buttonPedidos.UseVisualStyleBackColor = true;
            buttonPedidos.Click += buttonPedidos_Click;
            // 
            // Form_Clientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonPedidos);
            Controls.Add(dataGridViewClientes);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(labelErro);
            Controls.Add(label1);
            Controls.Add(buttonCadastrar);
            Controls.Add(textBoxEmail);
            Controls.Add(textBoxNome);
            Controls.Add(maskedBoxCPF);
            Controls.Add(maskedBoxTel);
            Name = "Form_Clientes";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaskedTextBox maskedBoxTel;
        private MaskedTextBox maskedBoxCPF;
        private TextBox textBoxNome;
        private TextBox textBoxEmail;
        private Button buttonCadastrar;
        private Label label1;
        private Label labelErro;
        private Label label3;
        private Label label4;
        private Label label5;
        private DataGridView dataGridViewClientes;
        private Button buttonPedidos;
    }
}
