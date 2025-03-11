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
            SuspendLayout();
            // 
            // textBoxn1
            // 
            textBoxn1.Location = new Point(234, 113);
            textBoxn1.Name = "textBoxn1";
            textBoxn1.Size = new Size(170, 23);
            textBoxn1.TabIndex = 0;
            // 
            // textBoxn2
            // 
            textBoxn2.Location = new Point(234, 171);
            textBoxn2.Name = "textBoxn2";
            textBoxn2.Size = new Size(170, 23);
            textBoxn2.TabIndex = 1;
            // 
            // labelCalcular
            // 
            labelCalcular.Location = new Point(275, 204);
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
            labelResultado.Location = new Point(199, 245);
            labelResultado.Name = "labelResultado";
            labelResultado.Size = new Size(0, 23);
            labelResultado.TabIndex = 4;
            // 
            // comboBoxOperacoes
            // 
            comboBoxOperacoes.FormattingEnabled = true;
            comboBoxOperacoes.Items.AddRange(new object[] { "+", "-", "*", "/" });
            comboBoxOperacoes.Location = new Point(260, 142);
            comboBoxOperacoes.Name = "comboBoxOperacoes";
            comboBoxOperacoes.Size = new Size(121, 23);
            comboBoxOperacoes.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}
