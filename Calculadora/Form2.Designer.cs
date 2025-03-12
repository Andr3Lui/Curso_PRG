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
            SuspendLayout();
            // 
            // buttonCalcular
            // 
            buttonCalcular.Location = new Point(304, 193);
            buttonCalcular.Name = "buttonCalcular";
            buttonCalcular.Size = new Size(75, 23);
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
            comboBoxOperacoes.Location = new Point(292, 159);
            comboBoxOperacoes.Name = "comboBoxOperacoes";
            comboBoxOperacoes.Size = new Size(98, 28);
            comboBoxOperacoes.TabIndex = 1;
            comboBoxOperacoes.Text = "operações";
            // 
            // textBoxn1
            // 
            textBoxn1.Location = new Point(290, 130);
            textBoxn1.Name = "textBoxn1";
            textBoxn1.Size = new Size(100, 23);
            textBoxn1.TabIndex = 3;
            // 
            // textBoxResultado
            // 
            textBoxResultado.Location = new Point(292, 222);
            textBoxResultado.Name = "textBoxResultado";
            textBoxResultado.ReadOnly = true;
            textBoxResultado.Size = new Size(100, 23);
            textBoxResultado.TabIndex = 4;
            // 
            // labelNotificacao
            // 
            labelNotificacao.AutoSize = true;
            labelNotificacao.Location = new Point(304, 306);
            labelNotificacao.Name = "labelNotificacao";
            labelNotificacao.Size = new Size(13, 15);
            labelNotificacao.TabIndex = 5;
            labelNotificacao.Text = "  ";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelNotificacao);
            Controls.Add(textBoxResultado);
            Controls.Add(textBoxn1);
            Controls.Add(comboBoxOperacoes);
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
    }
}