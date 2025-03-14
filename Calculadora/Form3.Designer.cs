namespace Calculadora
{
    partial class Form3
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
            textBoxRaio = new TextBox();
            radioButtonPerimetro = new RadioButton();
            radioButtonDiametro = new RadioButton();
            radioButtonArea = new RadioButton();
            radioButtonVolume = new RadioButton();
            buttonCalcular = new Button();
            labelRaio = new Label();
            textBoxResultado = new TextBox();
            labelResultado = new Label();
            labelErro = new Label();
            SuspendLayout();
            // 
            // textBoxRaio
            // 
            textBoxRaio.Location = new Point(102, 76);
            textBoxRaio.Name = "textBoxRaio";
            textBoxRaio.Size = new Size(100, 23);
            textBoxRaio.TabIndex = 0;
            // 
            // radioButtonPerimetro
            // 
            radioButtonPerimetro.AutoSize = true;
            radioButtonPerimetro.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radioButtonPerimetro.Location = new Point(102, 114);
            radioButtonPerimetro.Name = "radioButtonPerimetro";
            radioButtonPerimetro.Size = new Size(77, 19);
            radioButtonPerimetro.TabIndex = 1;
            radioButtonPerimetro.TabStop = true;
            radioButtonPerimetro.Text = "Perímetro";
            radioButtonPerimetro.UseVisualStyleBackColor = true;
            // 
            // radioButtonDiametro
            // 
            radioButtonDiametro.AutoSize = true;
            radioButtonDiametro.Location = new Point(102, 139);
            radioButtonDiametro.Name = "radioButtonDiametro";
            radioButtonDiametro.Size = new Size(81, 19);
            radioButtonDiametro.TabIndex = 2;
            radioButtonDiametro.TabStop = true;
            radioButtonDiametro.Text = "Diamentro";
            radioButtonDiametro.UseVisualStyleBackColor = true;
            // 
            // radioButtonArea
            // 
            radioButtonArea.AutoSize = true;
            radioButtonArea.Location = new Point(102, 164);
            radioButtonArea.Name = "radioButtonArea";
            radioButtonArea.Size = new Size(49, 19);
            radioButtonArea.TabIndex = 3;
            radioButtonArea.TabStop = true;
            radioButtonArea.Text = "Área";
            radioButtonArea.UseVisualStyleBackColor = true;
            // 
            // radioButtonVolume
            // 
            radioButtonVolume.AutoSize = true;
            radioButtonVolume.Location = new Point(102, 189);
            radioButtonVolume.Name = "radioButtonVolume";
            radioButtonVolume.Size = new Size(65, 19);
            radioButtonVolume.TabIndex = 4;
            radioButtonVolume.TabStop = true;
            radioButtonVolume.Text = "Volume";
            radioButtonVolume.UseVisualStyleBackColor = true;
            // 
            // buttonCalcular
            // 
            buttonCalcular.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonCalcular.Location = new Point(111, 223);
            buttonCalcular.Name = "buttonCalcular";
            buttonCalcular.Size = new Size(75, 23);
            buttonCalcular.TabIndex = 5;
            buttonCalcular.Text = "Calcular";
            buttonCalcular.UseVisualStyleBackColor = true;
            buttonCalcular.Click += buttonCalcular_Click;
            // 
            // labelRaio
            // 
            labelRaio.AutoSize = true;
            labelRaio.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelRaio.Location = new Point(102, 58);
            labelRaio.Name = "labelRaio";
            labelRaio.Size = new Size(79, 15);
            labelRaio.TabIndex = 6;
            labelRaio.Text = "Valor do Raio";
            // 
            // textBoxResultado
            // 
            textBoxResultado.Enabled = false;
            textBoxResultado.Location = new Point(325, 135);
            textBoxResultado.Name = "textBoxResultado";
            textBoxResultado.Size = new Size(100, 23);
            textBoxResultado.TabIndex = 7;
            // 
            // labelResultado
            // 
            labelResultado.AutoSize = true;
            labelResultado.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelResultado.Location = new Point(325, 114);
            labelResultado.Name = "labelResultado";
            labelResultado.Size = new Size(62, 15);
            labelResultado.TabIndex = 8;
            labelResultado.Text = "Resultado";
            // 
            // labelErro
            // 
            labelErro.AutoSize = true;
            labelErro.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelErro.Location = new Point(303, 189);
            labelErro.Name = "labelErro";
            labelErro.Size = new Size(0, 15);
            labelErro.TabIndex = 9;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelErro);
            Controls.Add(labelResultado);
            Controls.Add(textBoxResultado);
            Controls.Add(labelRaio);
            Controls.Add(buttonCalcular);
            Controls.Add(radioButtonVolume);
            Controls.Add(radioButtonArea);
            Controls.Add(radioButtonDiametro);
            Controls.Add(radioButtonPerimetro);
            Controls.Add(textBoxRaio);
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxRaio;
        private RadioButton radioButtonPerimetro;
        private RadioButton radioButtonDiametro;
        private RadioButton radioButtonArea;
        private RadioButton radioButtonVolume;
        private Button buttonCalcular;
        private Label labelRaio;
        private TextBox textBoxResultado;
        private Label labelResultado;
        private Label labelErro;
    }
}