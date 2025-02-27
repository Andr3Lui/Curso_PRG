namespace Login
{
    partial class Formulario_login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Formulario_login));
            textBoxUsuario = new TextBox();
            textBoxSenha = new TextBox();
            Logar = new Button();
            Email = new Label();
            Senha = new Label();
            ImagemGoogle = new PictureBox();
            labelResultado = new Label();
            printPreviewDialog1 = new PrintPreviewDialog();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)ImagemGoogle).BeginInit();
            SuspendLayout();
            // 
            // textBoxUsuario
            // 
            textBoxUsuario.Location = new Point(323, 232);
            textBoxUsuario.Name = "textBoxUsuario";
            textBoxUsuario.Size = new Size(199, 23);
            textBoxUsuario.TabIndex = 0;
            // 
            // textBoxSenha
            // 
            textBoxSenha.Location = new Point(323, 261);
            textBoxSenha.Name = "textBoxSenha";
            textBoxSenha.Size = new Size(199, 23);
            textBoxSenha.TabIndex = 1;
            // 
            // Logar
            // 
            Logar.FlatStyle = FlatStyle.System;
            Logar.Font = new Font("Arial Narrow", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Logar.ForeColor = SystemColors.ActiveCaptionText;
            Logar.Location = new Point(381, 301);
            Logar.Name = "Logar";
            Logar.Size = new Size(86, 30);
            Logar.TabIndex = 2;
            Logar.Text = "Logar";
            Logar.UseVisualStyleBackColor = true;
            Logar.Click += Logar_Click;
            // 
            // Email
            // 
            Email.AutoSize = true;
            Email.BackColor = SystemColors.HighlightText;
            Email.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Email.Location = new Point(260, 235);
            Email.Name = "Email";
            Email.Size = new Size(57, 20);
            Email.TabIndex = 3;
            Email.Text = "E-mail: ";
            // 
            // Senha
            // 
            Senha.AutoSize = true;
            Senha.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Senha.Location = new Point(261, 264);
            Senha.Name = "Senha";
            Senha.Size = new Size(56, 20);
            Senha.TabIndex = 4;
            Senha.Text = "Senha: ";
            // 
            // ImagemGoogle
            // 
            ImagemGoogle.Image = Properties.Resources.google_removebg_preview;
            ImagemGoogle.Location = new Point(116, 36);
            ImagemGoogle.Name = "ImagemGoogle";
            ImagemGoogle.Size = new Size(546, 190);
            ImagemGoogle.TabIndex = 5;
            ImagemGoogle.TabStop = false;
            // 
            // labelResultado
            // 
            labelResultado.AutoSize = true;
            labelResultado.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelResultado.Location = new Point(340, 368);
            labelResultado.Name = "labelResultado";
            labelResultado.Size = new Size(9, 20);
            labelResultado.TabIndex = 6;
            labelResultado.Text = "\r\n";
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.HighlightText;
            label1.Font = new Font("Arial Narrow", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DodgerBlue;
            label1.Location = new Point(361, 344);
            label1.Name = "label1";
            label1.Size = new Size(123, 16);
            label1.TabIndex = 7;
            label1.Text = "Esqueceu sua senha?";
            label1.Click += label1_Click;
            // 
            // Formulario_login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HighlightText;
            ClientSize = new Size(792, 460);
            Controls.Add(label1);
            Controls.Add(labelResultado);
            Controls.Add(ImagemGoogle);
            Controls.Add(Senha);
            Controls.Add(Email);
            Controls.Add(Logar);
            Controls.Add(textBoxSenha);
            Controls.Add(textBoxUsuario);
            Name = "Formulario_login";
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)ImagemGoogle).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxUsuario;
        private TextBox textBoxSenha;
        private Button Logar;
        private Label Email;
        private Label Senha;
        private PictureBox ImagemGoogle;
        private Label labelResultado;
        private PrintPreviewDialog printPreviewDialog1;
        private Label label1;
    }
}
