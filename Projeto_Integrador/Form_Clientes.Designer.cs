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
            pictureBox5 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCliente).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
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
            label1.Location = new Point(319, 217);
            label1.Name = "label1";
            label1.Size = new Size(35, 20);
            label1.TabIndex = 5;
            label1.Text = "CPF";
            // 
            // labelErro
            // 
            labelErro.AutoSize = true;
            labelErro.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelErro.Location = new Point(722, 563);
            labelErro.Name = "labelErro";
            labelErro.Size = new Size(51, 20);
            labelErro.TabIndex = 6;
            labelErro.Text = "label2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(94, 217);
            label3.Name = "label3";
            label3.Size = new Size(69, 20);
            label3.TabIndex = 7;
            label3.Text = "Telefone";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(332, 97);
            label4.Name = "label4";
            label4.Size = new Size(53, 20);
            label4.TabIndex = 8;
            label4.Text = "E-mail";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(94, 97);
            label5.Name = "label5";
            label5.Size = new Size(52, 20);
            label5.TabIndex = 9;
            label5.Text = "Nome";
            // 
            // dataGridViewCliente
            // 
            dataGridViewCliente.BackgroundColor = Color.BurlyWood;
            dataGridViewCliente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCliente.Location = new Point(722, 214);
            dataGridViewCliente.Margin = new Padding(3, 4, 3, 4);
            dataGridViewCliente.Name = "dataGridViewCliente";
            dataGridViewCliente.RowHeadersWidth = 51;
            dataGridViewCliente.Size = new Size(474, 320);
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
            buttonEditarCliente.Image = Properties.Resources.icons8_editar_24;
            buttonEditarCliente.Location = new Point(1219, 286);
            buttonEditarCliente.Margin = new Padding(3, 4, 3, 4);
            buttonEditarCliente.Name = "buttonEditarCliente";
            buttonEditarCliente.Size = new Size(73, 43);
            buttonEditarCliente.TabIndex = 13;
            buttonEditarCliente.UseVisualStyleBackColor = true;
            buttonEditarCliente.Click += buttonEditarCliente_Click;
            // 
            // buttonAtualizarCliente
            // 
            buttonAtualizarCliente.Cursor = Cursors.Hand;
            buttonAtualizarCliente.Image = Properties.Resources.icons8_synchronize_24;
            buttonAtualizarCliente.Location = new Point(1219, 353);
            buttonAtualizarCliente.Margin = new Padding(3, 4, 3, 4);
            buttonAtualizarCliente.Name = "buttonAtualizarCliente";
            buttonAtualizarCliente.Size = new Size(73, 42);
            buttonAtualizarCliente.TabIndex = 14;
            buttonAtualizarCliente.UseVisualStyleBackColor = true;
            buttonAtualizarCliente.Click += buttonAtualizarCliente_Click;
            // 
            // buttonDeletarCliente
            // 
            buttonDeletarCliente.Cursor = Cursors.Hand;
            buttonDeletarCliente.Image = Properties.Resources.icons8_trash_24;
            buttonDeletarCliente.Location = new Point(1219, 422);
            buttonDeletarCliente.Margin = new Padding(3, 4, 3, 4);
            buttonDeletarCliente.Name = "buttonDeletarCliente";
            buttonDeletarCliente.Size = new Size(73, 41);
            buttonDeletarCliente.TabIndex = 15;
            buttonDeletarCliente.UseVisualStyleBackColor = true;
            buttonDeletarCliente.Click += buttonDeletarCliente_Click;
            // 
            // buttonBuscarCliente
            // 
            buttonBuscarCliente.Cursor = Cursors.Hand;
            buttonBuscarCliente.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonBuscarCliente.Image = Properties.Resources.icons8_pesquisar_24;
            buttonBuscarCliente.Location = new Point(722, 180);
            buttonBuscarCliente.Name = "buttonBuscarCliente";
            buttonBuscarCliente.Size = new Size(89, 27);
            buttonBuscarCliente.TabIndex = 16;
            buttonBuscarCliente.UseVisualStyleBackColor = true;
            buttonBuscarCliente.Click += buttonBuscarCliente_Click;
            // 
            // textBoxBuscar
            // 
            textBoxBuscar.Cursor = Cursors.IBeam;
            textBoxBuscar.Location = new Point(817, 180);
            textBoxBuscar.Name = "textBoxBuscar";
            textBoxBuscar.Size = new Size(379, 27);
            textBoxBuscar.TabIndex = 17;
            textBoxBuscar.TextChanged += textBoxBuscar_TextChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(pictureBox5);
            groupBox1.Controls.Add(pictureBox4);
            groupBox1.Controls.Add(pictureBox3);
            groupBox1.Controls.Add(pictureBox2);
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
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.icons8_phone_25;
            pictureBox5.Location = new Point(63, 214);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(32, 23);
            pictureBox5.TabIndex = 13;
            pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.icons8_mailbox_24;
            pictureBox4.Location = new Point(295, 94);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(31, 23);
            pictureBox4.TabIndex = 12;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.icons8_informações_24;
            pictureBox3.Location = new Point(295, 212);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(29, 25);
            pictureBox3.TabIndex = 11;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.icons8_usuário_24;
            pictureBox2.Location = new Point(62, 92);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(26, 25);
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
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
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form_Clientes";
            Text = "HairSharp";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewCliente).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
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
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
    }
}
