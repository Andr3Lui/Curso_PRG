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
            pictureBox1 = new PictureBox();
            buttonEditarCliente = new Button();
            buttonAtualizarCliente = new Button();
            buttonDeletarCliente = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewClientes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // maskedBoxTel
            // 
            maskedBoxTel.Location = new Point(12, 457);
            maskedBoxTel.Mask = "(00)00000-0000";
            maskedBoxTel.Name = "maskedBoxTel";
            maskedBoxTel.Size = new Size(101, 23);
            maskedBoxTel.TabIndex = 0;
            // 
            // maskedBoxCPF
            // 
            maskedBoxCPF.Location = new Point(132, 457);
            maskedBoxCPF.Mask = "000.000.000-00";
            maskedBoxCPF.Name = "maskedBoxCPF";
            maskedBoxCPF.Size = new Size(100, 23);
            maskedBoxCPF.TabIndex = 1;
            // 
            // textBoxNome
            // 
            textBoxNome.Location = new Point(13, 401);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(100, 23);
            textBoxNome.TabIndex = 2;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(132, 401);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(100, 23);
            textBoxEmail.TabIndex = 3;
            // 
            // buttonCadastrar
            // 
            buttonCadastrar.Location = new Point(73, 497);
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
            label1.Location = new Point(132, 439);
            label1.Name = "label1";
            label1.Size = new Size(28, 15);
            label1.TabIndex = 5;
            label1.Text = "CPF";
            // 
            // labelErro
            // 
            labelErro.AutoSize = true;
            labelErro.Location = new Point(12, 629);
            labelErro.Name = "labelErro";
            labelErro.Size = new Size(38, 15);
            labelErro.TabIndex = 6;
            labelErro.Text = "label2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 439);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 7;
            label3.Text = "Telefone";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(132, 383);
            label4.Name = "label4";
            label4.Size = new Size(41, 15);
            label4.TabIndex = 8;
            label4.Text = "E-mail";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(13, 383);
            label5.Name = "label5";
            label5.Size = new Size(40, 15);
            label5.TabIndex = 9;
            label5.Text = "Nome";
            // 
            // dataGridViewClientes
            // 
            dataGridViewClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewClientes.Location = new Point(548, 343);
            dataGridViewClientes.Name = "dataGridViewClientes";
            dataGridViewClientes.Size = new Size(415, 268);
            dataGridViewClientes.TabIndex = 10;
            // 
            // buttonPedidos
            // 
            buttonPedidos.Location = new Point(73, 551);
            buttonPedidos.Name = "buttonPedidos";
            buttonPedidos.Size = new Size(100, 30);
            buttonPedidos.TabIndex = 11;
            buttonPedidos.Text = "Pedidos";
            buttonPedidos.UseVisualStyleBackColor = true;
            buttonPedidos.Click += buttonPedidos_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Adobe_Express___file__1___1_;
            pictureBox1.Location = new Point(198, -2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(417, 325);
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // buttonEditarCliente
            // 
            buttonEditarCliente.Location = new Point(451, 401);
            buttonEditarCliente.Name = "buttonEditarCliente";
            buttonEditarCliente.Size = new Size(75, 23);
            buttonEditarCliente.TabIndex = 13;
            buttonEditarCliente.Text = "Editar";
            buttonEditarCliente.UseVisualStyleBackColor = true;
            buttonEditarCliente.Click += buttonEditarCliente_Click;
            // 
            // buttonAtualizarCliente
            // 
            buttonAtualizarCliente.Location = new Point(451, 439);
            buttonAtualizarCliente.Name = "buttonAtualizarCliente";
            buttonAtualizarCliente.Size = new Size(75, 23);
            buttonAtualizarCliente.TabIndex = 14;
            buttonAtualizarCliente.Text = "Atualizar";
            buttonAtualizarCliente.UseVisualStyleBackColor = true;
            buttonAtualizarCliente.Click += buttonAtualizarCliente_Click;
            // 
            // buttonDeletarCliente
            // 
            buttonDeletarCliente.Location = new Point(451, 483);
            buttonDeletarCliente.Name = "buttonDeletarCliente";
            buttonDeletarCliente.Size = new Size(75, 23);
            buttonDeletarCliente.TabIndex = 15;
            buttonDeletarCliente.Text = "Deletar";
            buttonDeletarCliente.UseVisualStyleBackColor = true;
            buttonDeletarCliente.Click += buttonDeletarCliente_Click;
            // 
            // Form_Clientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(975, 653);
            Controls.Add(buttonDeletarCliente);
            Controls.Add(buttonAtualizarCliente);
            Controls.Add(buttonEditarCliente);
            Controls.Add(pictureBox1);
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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private PictureBox pictureBox1;
        private Button buttonEditarCliente;
        private Button buttonAtualizarCliente;
        private Button buttonDeletarCliente;
    }
}
