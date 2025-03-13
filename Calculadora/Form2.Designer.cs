namespace Calculadora
{
    partial class Form2
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
            buttonCalcular = new Button();
            comboBoxOperacoes = new ComboBox();
            textBoxn1 = new TextBox();
            textBoxResultado = new TextBox();
            labelNotificacao = new Label();
            textBoxComprimento = new TextBox();
            textBoxAltura = new TextBox();
            textBoxLargura = new TextBox();
            comboBoxOperacoes2 = new ComboBox();
            botaoCalcular = new Button();
            boxResultado = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            labelNotificacao2 = new Label();
            SuspendLayout();
            // 
            // buttonCalcular
            // 
            buttonCalcular.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonCalcular.Location = new Point(76, 177);
            buttonCalcular.Name = "buttonCalcular";
            buttonCalcular.Size = new Size(100, 23);
            buttonCalcular.TabIndex = 0;
            buttonCalcular.Text = "Calcular";
            buttonCalcular.UseVisualStyleBackColor = true;
            buttonCalcular.Click += button1_Click;
            // 
            // comboBoxOperacoes
            // 
            comboBoxOperacoes.Font = new Font("Arial Narrow", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            comboBoxOperacoes.FormattingEnabled = true;
            comboBoxOperacoes.Items.AddRange(new object[] { "Perímetro", "Área", "Volume" });
            comboBoxOperacoes.Location = new Point(76, 143);
            comboBoxOperacoes.Name = "comboBoxOperacoes";
            comboBoxOperacoes.Size = new Size(100, 28);
            comboBoxOperacoes.TabIndex = 1;
            comboBoxOperacoes.Text = "operações";
            // 
            // textBoxn1
            // 
            textBoxn1.Location = new Point(76, 114);
            textBoxn1.Name = "textBoxn1";
            textBoxn1.Size = new Size(100, 23);
            textBoxn1.TabIndex = 3;
            // 
            // textBoxResultado
            // 
            textBoxResultado.Location = new Point(76, 226);
            textBoxResultado.Name = "textBoxResultado";
            textBoxResultado.ReadOnly = true;
            textBoxResultado.Size = new Size(100, 23);
            textBoxResultado.TabIndex = 4;
            // 
            // labelNotificacao
            // 
            labelNotificacao.AutoSize = true;
            labelNotificacao.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelNotificacao.Location = new Point(76, 281);
            labelNotificacao.Name = "labelNotificacao";
            labelNotificacao.Size = new Size(13, 15);
            labelNotificacao.TabIndex = 5;
            labelNotificacao.Text = "  ";
            // 
            // textBoxComprimento
            // 
            textBoxComprimento.Location = new Point(339, 117);
            textBoxComprimento.Name = "textBoxComprimento";
            textBoxComprimento.Size = new Size(100, 23);
            textBoxComprimento.TabIndex = 8;
            // 
            // textBoxAltura
            // 
            textBoxAltura.Enabled = false;
            textBoxAltura.Location = new Point(551, 117);
            textBoxAltura.Name = "textBoxAltura";
            textBoxAltura.Size = new Size(100, 23);
            textBoxAltura.TabIndex = 9;
            // 
            // textBoxLargura
            // 
            textBoxLargura.Location = new Point(445, 117);
            textBoxLargura.Name = "textBoxLargura";
            textBoxLargura.Size = new Size(100, 23);
            textBoxLargura.TabIndex = 10;
            // 
            // comboBoxOperacoes2
            // 
            comboBoxOperacoes2.Font = new Font("Arial Narrow", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            comboBoxOperacoes2.FormattingEnabled = true;
            comboBoxOperacoes2.Items.AddRange(new object[] { "Perímetro", "Área", "Volume" });
            comboBoxOperacoes2.Location = new Point(445, 146);
            comboBoxOperacoes2.Name = "comboBoxOperacoes2";
            comboBoxOperacoes2.Size = new Size(100, 28);
            comboBoxOperacoes2.TabIndex = 11;
            comboBoxOperacoes2.Text = "operações";
            comboBoxOperacoes2.SelectedIndexChanged += comboBoxOperacoes2_SelectedIndexChanged;
            // 
            // botaoCalcular
            // 
            botaoCalcular.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            botaoCalcular.Location = new Point(445, 180);
            botaoCalcular.Name = "botaoCalcular";
            botaoCalcular.Size = new Size(100, 23);
            botaoCalcular.TabIndex = 12;
            botaoCalcular.Text = "Calcular";
            botaoCalcular.UseVisualStyleBackColor = true;
            botaoCalcular.Click += botaoCalcular_Click;
            // 
            // boxResultado
            // 
            boxResultado.Location = new Point(445, 226);
            boxResultado.Name = "boxResultado";
            boxResultado.ReadOnly = true;
            boxResultado.Size = new Size(100, 23);
            boxResultado.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(339, 99);
            label1.Name = "label1";
            label1.Size = new Size(84, 15);
            label1.TabIndex = 14;
            label1.Text = "Comprimento";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(445, 99);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 15;
            label2.Text = "Largura";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(551, 99);
            label3.Name = "label3";
            label3.Size = new Size(41, 15);
            label3.TabIndex = 16;
            label3.Text = "Altura";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(76, 49);
            label4.Name = "label4";
            label4.Size = new Size(103, 22);
            label4.TabIndex = 19;
            label4.Text = "Quadrado";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(445, 49);
            label5.Name = "label5";
            label5.Size = new Size(104, 22);
            label5.TabIndex = 20;
            label5.Text = "Retângulo";
            // 
            // labelNotificacao2
            // 
            labelNotificacao2.AutoSize = true;
            labelNotificacao2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelNotificacao2.Location = new Point(445, 281);
            labelNotificacao2.Name = "labelNotificacao2";
            labelNotificacao2.Size = new Size(13, 15);
            labelNotificacao2.TabIndex = 21;
            labelNotificacao2.Text = "  ";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelNotificacao2);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(comboBoxOperacoes);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(boxResultado);
            Controls.Add(botaoCalcular);
            Controls.Add(comboBoxOperacoes2);
            Controls.Add(textBoxLargura);
            Controls.Add(textBoxAltura);
            Controls.Add(textBoxComprimento);
            Controls.Add(labelNotificacao);
            Controls.Add(textBoxResultado);
            Controls.Add(textBoxn1);
            Controls.Add(buttonCalcular);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonCalcular;
        private ComboBox comboBoxOperacoes;
        private TextBox textBoxn1;
        private TextBox textBoxResultado;
        private Label labelNotificacao;
        private TextBox textBoxComprimento;
        private TextBox textBoxAltura;
        private TextBox textBoxLargura;
        private ComboBox comboBoxOperacoes2;
        private Button botaoCalcular;
        private TextBox boxResultado;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label labelNotificacao2;
    }
}