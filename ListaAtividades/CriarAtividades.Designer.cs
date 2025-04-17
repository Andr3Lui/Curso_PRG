namespace ListaAtividades
{
    partial class CriarAtividades
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
            buttonDescartar = new Button();
            buttonCriarAtividade = new Button();
            textBoxTitulo = new TextBox();
            labelTitulo = new Label();
            labelErro = new Label();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // buttonDescartar
            // 
            buttonDescartar.Location = new Point(328, 265);
            buttonDescartar.Name = "buttonDescartar";
            buttonDescartar.Size = new Size(75, 23);
            buttonDescartar.TabIndex = 0;
            buttonDescartar.Text = "Descartar";
            buttonDescartar.UseVisualStyleBackColor = true;
            buttonDescartar.Click += buttonDescartar_Click;
            // 
            // buttonCriarAtividade
            // 
            buttonCriarAtividade.Location = new Point(409, 265);
            buttonCriarAtividade.Name = "buttonCriarAtividade";
            buttonCriarAtividade.Size = new Size(75, 23);
            buttonCriarAtividade.TabIndex = 1;
            buttonCriarAtividade.Text = "Criar";
            buttonCriarAtividade.UseVisualStyleBackColor = true;
            buttonCriarAtividade.Click += buttonCriarAtividade_Click;
            // 
            // textBoxTitulo
            // 
            textBoxTitulo.Location = new Point(350, 236);
            textBoxTitulo.Name = "textBoxTitulo";
            textBoxTitulo.Size = new Size(100, 23);
            textBoxTitulo.TabIndex = 2;
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Location = new Point(382, 218);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(37, 15);
            labelTitulo.TabIndex = 3;
            labelTitulo.Text = "Título";
            // 
            // labelErro
            // 
            labelErro.AutoSize = true;
            labelErro.Location = new Point(18, 396);
            labelErro.Name = "labelErro";
            labelErro.Size = new Size(38, 15);
            labelErro.TabIndex = 4;
            labelErro.Text = "label2";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBoxTitulo);
            groupBox1.Controls.Add(buttonCriarAtividade);
            groupBox1.Controls.Add(labelErro);
            groupBox1.Controls.Add(buttonDescartar);
            groupBox1.Controls.Add(labelTitulo);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(776, 426);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // CriarAtividades
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Name = "CriarAtividades";
            Text = "CriarAtividades";
            Load += CriarAtividades_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonDescartar;
        private Button buttonCriarAtividade;
        private TextBox textBoxTitulo;
        private Label labelTitulo;
        private Label labelErro;
        private GroupBox groupBox1;
    }
}