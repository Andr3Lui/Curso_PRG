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
            Email = new Label();
            Senha = new Label();
            ImagemGoogle = new PictureBox();
            labelResultado = new Label();
            printPreviewDialog1 = new PrintPreviewDialog();
            EsqSenha = new Label();
            ImagemGoogle2 = new PictureBox();
            txbCadUsu = new TextBox();
            txbCadSen = new TextBox();
            labResultado = new Label();
            CadUsuario = new Label();
            CadSenha = new Label();
            Criar = new Button();
            PrecAjuda = new Label();
            Logar = new Button();
            ((System.ComponentModel.ISupportInitialize)ImagemGoogle).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ImagemGoogle2).BeginInit();
            SuspendLayout();
            // 
            // textBoxUsuario
            // 
            textBoxUsuario.Location = new Point(234, 236);
            textBoxUsuario.Name = "textBoxUsuario";
            textBoxUsuario.Size = new Size(199, 23);
            textBoxUsuario.TabIndex = 0;
            // 
            // textBoxSenha
            // 
            textBoxSenha.Location = new Point(234, 265);
            textBoxSenha.Name = "textBoxSenha";
            textBoxSenha.Size = new Size(199, 23);
            textBoxSenha.TabIndex = 1;
            // 
            // Email
            // 
            Email.AutoSize = true;
            Email.BackColor = SystemColors.HighlightText;
            Email.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Email.Location = new Point(171, 239);
            Email.Name = "Email";
            Email.Size = new Size(57, 20);
            Email.TabIndex = 3;
            Email.Text = "E-mail: ";
            // 
            // Senha
            // 
            Senha.AutoSize = true;
            Senha.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Senha.Location = new Point(171, 268);
            Senha.Name = "Senha";
            Senha.Size = new Size(56, 20);
            Senha.TabIndex = 4;
            Senha.Text = "Senha: ";
            // 
            // ImagemGoogle
            // 
            ImagemGoogle.Image = Properties.Resources.google_removebg_preview;
            ImagemGoogle.Location = new Point(38, 36);
            ImagemGoogle.Name = "ImagemGoogle";
            ImagemGoogle.Size = new Size(546, 190);
            ImagemGoogle.TabIndex = 5;
            ImagemGoogle.TabStop = false;
            // 
            // labelResultado
            // 
            labelResultado.AutoSize = true;
            labelResultado.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelResultado.Location = new Point(274, 369);
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
            // EsqSenha
            // 
            EsqSenha.AutoSize = true;
            EsqSenha.BackColor = SystemColors.HighlightText;
            EsqSenha.Font = new Font("Arial Narrow", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EsqSenha.ForeColor = Color.DodgerBlue;
            EsqSenha.Location = new Point(274, 338);
            EsqSenha.Name = "EsqSenha";
            EsqSenha.Size = new Size(123, 16);
            EsqSenha.TabIndex = 7;
            EsqSenha.Text = "Esqueceu sua senha?";
            EsqSenha.Click += EsqSenha_Click;
            // 
            // ImagemGoogle2
            // 
            ImagemGoogle2.Image = Properties.Resources.google_removebg_preview;
            ImagemGoogle2.Location = new Point(727, 36);
            ImagemGoogle2.Name = "ImagemGoogle2";
            ImagemGoogle2.Size = new Size(546, 190);
            ImagemGoogle2.TabIndex = 9;
            ImagemGoogle2.TabStop = false;
            // 
            // txbCadUsu
            // 
            txbCadUsu.Location = new Point(900, 236);
            txbCadUsu.Name = "txbCadUsu";
            txbCadUsu.Size = new Size(192, 23);
            txbCadUsu.TabIndex = 10;
            // 
            // txbCadSen
            // 
            txbCadSen.Location = new Point(900, 265);
            txbCadSen.Name = "txbCadSen";
            txbCadSen.Size = new Size(192, 23);
            txbCadSen.TabIndex = 11;
            // 
            // labResultado
            // 
            labResultado.AutoSize = true;
            labResultado.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labResultado.Location = new Point(946, 369);
            labResultado.Name = "labResultado";
            labResultado.Size = new Size(21, 20);
            labResultado.TabIndex = 12;
            labResultado.Text = "   ";
            // 
            // CadUsuario
            // 
            CadUsuario.AutoSize = true;
            CadUsuario.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CadUsuario.Location = new Point(778, 239);
            CadUsuario.Name = "CadUsuario";
            CadUsuario.Size = new Size(116, 20);
            CadUsuario.TabIndex = 13;
            CadUsuario.Text = "Cadastrar E-mail:";
            // 
            // CadSenha
            // 
            CadSenha.AutoSize = true;
            CadSenha.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CadSenha.Location = new Point(778, 268);
            CadSenha.Name = "CadSenha";
            CadSenha.Size = new Size(115, 20);
            CadSenha.TabIndex = 14;
            CadSenha.Text = "Cadastrar Senha:";
            // 
            // Criar
            // 
            Criar.Font = new Font("Arial Narrow", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Criar.Location = new Point(946, 296);
            Criar.Name = "Criar";
            Criar.Size = new Size(102, 28);
            Criar.TabIndex = 15;
            Criar.Text = "Criar E-mail";
            Criar.UseVisualStyleBackColor = true;
            Criar.Click += BotaoCriar_Click;
            // 
            // PrecAjuda
            // 
            PrecAjuda.AutoSize = true;
            PrecAjuda.Font = new Font("Arial Narrow", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PrecAjuda.ForeColor = Color.DodgerBlue;
            PrecAjuda.Location = new Point(917, 339);
            PrecAjuda.Name = "PrecAjuda";
            PrecAjuda.Size = new Size(166, 16);
            PrecAjuda.TabIndex = 16;
            PrecAjuda.Text = "Precisa de ajuda? Clique aqui.";
            PrecAjuda.Click += PrecAjuda_Click;
            // 
            // Logar
            // 
            Logar.FlatStyle = FlatStyle.System;
            Logar.Font = new Font("Arial Narrow", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Logar.ForeColor = SystemColors.ActiveCaptionText;
            Logar.Location = new Point(292, 294);
            Logar.Name = "Logar";
            Logar.Size = new Size(86, 30);
            Logar.TabIndex = 2;
            Logar.Text = "Logar";
            Logar.UseVisualStyleBackColor = true;
            Logar.Click += Logar_Click;
            // 
            // Formulario_login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HighlightText;
            ClientSize = new Size(1302, 460);
            Controls.Add(PrecAjuda);
            Controls.Add(Criar);
            Controls.Add(CadSenha);
            Controls.Add(CadUsuario);
            Controls.Add(labResultado);
            Controls.Add(txbCadSen);
            Controls.Add(txbCadUsu);
            Controls.Add(ImagemGoogle2);
            Controls.Add(EsqSenha);
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
            ((System.ComponentModel.ISupportInitialize)ImagemGoogle2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxUsuario;
        private TextBox textBoxSenha;
        private Label Email;
        private Label Senha;
        private PictureBox ImagemGoogle;
        private Label labelResultado;
        private PrintPreviewDialog printPreviewDialog1;
        private Label EsqSenha;
        private PictureBox ImagemGoogle2;
        private TextBox txbCadUsu;
        private TextBox txbCadSen;
        private Label labResultado;
        private Label CadUsuario;
        private Label CadSenha;
        private Button Criar;
        private Label PrecAjuda;
        private Button Logar;
    }
}
