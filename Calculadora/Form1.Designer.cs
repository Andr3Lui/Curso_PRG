namespace Calculadora
{
    partial class Form1
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
            textBoxn1 = new TextBox();
            textBoxn2 = new TextBox();
            labelCalcular = new Button();
            labelResultado = new Label();
            comboBoxOperacoes = new ComboBox();
            textBoxResultado = new TextBox();
            label1 = new Label();
            labelLink = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // textBoxn1
            // 
            textBoxn1.Location = new Point(202, 113);
            textBoxn1.Name = "textBoxn1";
            textBoxn1.Size = new Size(69, 23);
            textBoxn1.TabIndex = 0;
            // 
            // textBoxn2
            // 
            textBoxn2.Location = new Point(333, 113);
            textBoxn2.Name = "textBoxn2";
            textBoxn2.Size = new Size(69, 23);
            textBoxn2.TabIndex = 1;
            // 
            // labelCalcular
            // 
            labelCalcular.Location = new Point(265, 142);
            labelCalcular.Name = "labelCalcular";
            labelCalcular.Size = new Size(75, 23);
            labelCalcular.TabIndex = 3;
            labelCalcular.Text = "Calcular";
            labelCalcular.UseVisualStyleBackColor = true;
            labelCalcular.Click += button1_Click;
            // 
            // labelResultado
            // 
            labelResultado.AutoSize = true;
            labelResultado.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelResultado.Location = new Point(310, 257);
            labelResultado.Name = "labelResultado";
            labelResultado.Size = new Size(0, 23);
            labelResultado.TabIndex = 4;
            // 
            // comboBoxOperacoes
            // 
            comboBoxOperacoes.FormattingEnabled = true;
            comboBoxOperacoes.Items.AddRange(new object[] { "+", "-", "*", "/" });
            comboBoxOperacoes.Location = new Point(277, 113);
            comboBoxOperacoes.Name = "comboBoxOperacoes";
            comboBoxOperacoes.Size = new Size(50, 23);
            comboBoxOperacoes.TabIndex = 5;
            // 
            // textBoxResultado
            // 
            textBoxResultado.Location = new Point(429, 113);
            textBoxResultado.Name = "textBoxResultado";
            textBoxResultado.ReadOnly = true;
            textBoxResultado.Size = new Size(69, 23);
            textBoxResultado.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(408, 116);
            label1.Name = "label1";
            label1.Size = new Size(15, 15);
            label1.TabIndex = 7;
            label1.Text = "=";
            // 
            // labelLink
            // 
            labelLink.AutoSize = true;
            labelLink.Cursor = Cursors.Hand;
            labelLink.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            labelLink.ForeColor = Color.DodgerBlue;
            labelLink.Location = new Point(185, 191);
            labelLink.Name = "labelLink";
            labelLink.Size = new Size(238, 15);
            labelLink.TabIndex = 8;
            labelLink.Text = "Calcular medidas de quadrado e retângulo";
            labelLink.Click += labelLink_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Cursor = Cursors.Hand;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DodgerBlue;
            label2.Location = new Point(218, 217);
            label2.Name = "label2";
            label2.Size = new Size(177, 15);
            label2.TabIndex = 9;
            label2.Text = "Calcular medidas de um circulo";
            label2.Click += label2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(labelLink);
            Controls.Add(label1);
            Controls.Add(textBoxResultado);
            Controls.Add(comboBoxOperacoes);
            Controls.Add(labelResultado);
            Controls.Add(labelCalcular);
            Controls.Add(textBoxn2);
            Controls.Add(textBoxn1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxn1;
        private TextBox textBoxn2;
        private Button labelCalcular;
        private Label labelResultado;
        private ComboBox comboBoxOperacoes;
        private TextBox textBoxResultado;
        private Label label1;
        private Label labelLink;
        private Label label2;
    }
}
