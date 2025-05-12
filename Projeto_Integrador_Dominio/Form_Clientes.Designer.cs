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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Clientes));
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
            dataGridViewCliente = new DataGridView();
            buttonPedidos = new Button();
            buttonEditarCliente = new Button();
            buttonAtualizarCliente = new Button();
            buttonDeletarCliente = new Button();
            buttonBuscarCliente = new Button();
            textBoxBuscar = new TextBox();
            groupBox1 = new GroupBox();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCliente).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // maskedBoxTel
            // 
            maskedBoxTel.Cursor = Cursors.IBeam;
            maskedBoxTel.Location = new Point(62, 241);
            maskedBoxTel.Margin = new Padding(3, 4, 3, 4);
            maskedBoxTel.Mask = "(00)00000-0000";
            maskedBoxTel.Name = "maskedBoxTel";
            maskedBoxTel.Size = new Size(115, 27);
            maskedBoxTel.TabIndex = 0;
            // 
            // maskedBoxCPF
            // 
            maskedBoxCPF.Cursor = Cursors.IBeam;
            maskedBoxCPF.Location = new Point(295, 241);
            maskedBoxCPF.Margin = new Padding(3, 4, 3, 4);
            maskedBoxCPF.Mask = "000.000.000-00";
            maskedBoxCPF.Name = "maskedBoxCPF";
            maskedBoxCPF.Size = new Size(114, 27);
            maskedBoxCPF.TabIndex = 1;
            // 
            // textBoxNome
            // 
            textBoxNome.Cursor = Cursors.IBeam;
            textBoxNome.Location = new Point(63, 121);
            textBoxNome.Margin = new Padding(3, 4, 3, 4);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(114, 27);
            textBoxNome.TabIndex = 2;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Cursor = Cursors.IBeam;
            textBoxEmail.Location = new Point(295, 121);
            textBoxEmail.Margin = new Padding(3, 4, 3, 4);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(114, 27);
            textBoxEmail.TabIndex = 3;
            // 
            // buttonCadastrar
            // 
            buttonCadastrar.BackColor = Color.BurlyWood;
            buttonCadastrar.Cursor = Cursors.Hand;
            buttonCadastrar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonCadastrar.Location = new Point(311, 529);
            buttonCadastrar.Margin = new Padding(3, 4, 3, 4);
            buttonCadastrar.Name = "buttonCadastrar";
            buttonCadastrar.Size = new Size(114, 40);
            buttonCadastrar.TabIndex = 4;
            buttonCadastrar.Text = "Cadastrar";
            buttonCadastrar.UseVisualStyleBackColor = false;
            buttonCadastrar.Click += buttonCadastrar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(337, 217);
            label1.Name = "label1";
            label1.Size = new Size(35, 20);
            label1.TabIndex = 5;
            label1.Text = "CPF";
            // 
            // labelErro
            // 
            labelErro.AutoSize = true;
            labelErro.Location = new Point(14, 839);
            labelErro.Name = "labelErro";
            labelErro.Size = new Size(50, 20);
            labelErro.TabIndex = 6;
            labelErro.Text = "label2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(108, 217);
            label3.Name = "label3";
            label3.Size = new Size(69, 20);
            label3.TabIndex = 7;
            label3.Text = "Telefone";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(356, 97);
            label4.Name = "label4";
            label4.Size = new Size(53, 20);
            label4.TabIndex = 8;
            label4.Text = "E-mail";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(125, 97);
            label5.Name = "label5";
            label5.Size = new Size(52, 20);
            label5.TabIndex = 9;
            label5.Text = "Nome";
            // 
            // dataGridViewCliente
            // 
            dataGridViewCliente.BackgroundColor = Color.BurlyWood;
            dataGridViewCliente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCliente.Location = new Point(722, 181);
            dataGridViewCliente.Margin = new Padding(3, 4, 3, 4);
            dataGridViewCliente.Name = "dataGridViewCliente";
            dataGridViewCliente.RowHeadersWidth = 51;
            dataGridViewCliente.Size = new Size(474, 357);
            dataGridViewCliente.TabIndex = 10;
            // 
            // buttonPedidos
            // 
            buttonPedidos.BackColor = Color.BurlyWood;
            buttonPedidos.Cursor = Cursors.Hand;
            buttonPedidos.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonPedidos.Location = new Point(311, 594);
            buttonPedidos.Margin = new Padding(3, 4, 3, 4);
            buttonPedidos.Name = "buttonPedidos";
            buttonPedidos.Size = new Size(114, 40);
            buttonPedidos.TabIndex = 11;
            buttonPedidos.Text = "Pedidos";
            buttonPedidos.UseVisualStyleBackColor = false;
            buttonPedidos.Click += buttonPedidos_Click;
            // 
            // buttonEditarCliente
            // 
            buttonEditarCliente.Cursor = Cursors.Hand;
            buttonEditarCliente.Location = new Point(1219, 218);
            buttonEditarCliente.Margin = new Padding(3, 4, 3, 4);
            buttonEditarCliente.Name = "buttonEditarCliente";
            buttonEditarCliente.Size = new Size(86, 31);
            buttonEditarCliente.TabIndex = 13;
            buttonEditarCliente.Text = "Editar";
            buttonEditarCliente.UseVisualStyleBackColor = true;
            buttonEditarCliente.Click += buttonEditarCliente_Click;
            // 
            // buttonAtualizarCliente
            // 
            buttonAtualizarCliente.Cursor = Cursors.Hand;
            buttonAtualizarCliente.Location = new Point(1219, 349);
            buttonAtualizarCliente.Margin = new Padding(3, 4, 3, 4);
            buttonAtualizarCliente.Name = "buttonAtualizarCliente";
            buttonAtualizarCliente.Size = new Size(86, 31);
            buttonAtualizarCliente.TabIndex = 14;
            buttonAtualizarCliente.Text = "Atualizar";
            buttonAtualizarCliente.UseVisualStyleBackColor = true;
            buttonAtualizarCliente.Click += buttonAtualizarCliente_Click;
            // 
            // buttonDeletarCliente
            // 
            buttonDeletarCliente.Cursor = Cursors.Hand;
            buttonDeletarCliente.Location = new Point(1219, 470);
            buttonDeletarCliente.Margin = new Padding(3, 4, 3, 4);
            buttonDeletarCliente.Name = "buttonDeletarCliente";
            buttonDeletarCliente.Size = new Size(86, 31);
            buttonDeletarCliente.TabIndex = 15;
            buttonDeletarCliente.Text = "Deletar";
            buttonDeletarCliente.UseVisualStyleBackColor = true;
            buttonDeletarCliente.Click += buttonDeletarCliente_Click;
            // 
            // buttonBuscarCliente
            // 
            buttonBuscarCliente.Cursor = Cursors.Hand;
            buttonBuscarCliente.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonBuscarCliente.Location = new Point(722, 147);
            buttonBuscarCliente.Name = "buttonBuscarCliente";
            buttonBuscarCliente.Size = new Size(89, 27);
            buttonBuscarCliente.TabIndex = 16;
            buttonBuscarCliente.Text = "Buscar";
            buttonBuscarCliente.UseVisualStyleBackColor = true;
            buttonBuscarCliente.Click += buttonBuscarCliente_Click;
            // 
            // textBoxBuscar
            // 
            textBoxBuscar.Cursor = Cursors.IBeam;
            textBoxBuscar.Location = new Point(817, 147);
            textBoxBuscar.Name = "textBoxBuscar";
            textBoxBuscar.Size = new Size(379, 27);
            textBoxBuscar.TabIndex = 17;
            textBoxBuscar.TextChanged += textBoxBuscar_TextChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBoxNome);
            groupBox1.Controls.Add(maskedBoxTel);
            groupBox1.Controls.Add(maskedBoxCPF);
            groupBox1.Controls.Add(textBoxEmail);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label5);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(112, 181);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(513, 320);
            groupBox1.TabIndex = 18;
            groupBox1.TabStop = false;
            groupBox1.Text = "Informações Pessoais";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(431, 508);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(472, 439);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Elephant", 17.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(519, 65);
            label2.Name = "label2";
            label2.Size = new Size(325, 38);
            label2.TabIndex = 20;
            label2.Text = "Cadastro de Clientes";
            // 
            // Form_Clientes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1363, 871);
            Controls.Add(label2);
            Controls.Add(groupBox1);
            Controls.Add(textBoxBuscar);
            Controls.Add(buttonBuscarCliente);
            Controls.Add(buttonDeletarCliente);
            Controls.Add(buttonCadastrar);
            Controls.Add(buttonAtualizarCliente);
            Controls.Add(buttonPedidos);
            Controls.Add(buttonEditarCliente);
            Controls.Add(dataGridViewCliente);
            Controls.Add(labelErro);
            Controls.Add(pictureBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form_Clientes";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewCliente).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
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
        private DataGridView dataGridViewCliente;
        private Button buttonPedidos;
        private Button buttonEditarCliente;
        private Button buttonAtualizarCliente;
        private Button buttonDeletarCliente;
        private Button buttonBuscarCliente;
        private TextBox textBoxBuscar;
        private GroupBox groupBox1;
        private PictureBox pictureBox1;
        private Label label2;
    }
}
