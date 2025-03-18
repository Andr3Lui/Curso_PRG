using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            

            labelErro.Text = "";

            if (string.IsNullOrWhiteSpace(textBoxRaio.Text) || !textBoxRaio.Text.All(char.IsNumber))
            {
                labelErro.Text = "Insira um valor válido";
                labelErro.ForeColor = Color.Red;
                return;
            }


            if (!radioButtonPerimetro.Checked && !radioButtonDiametro.Checked && !radioButtonArea.Checked && !radioButtonVolume.Checked)
            {
                labelErro.Text = "Escolha uma opção de calculo";
                labelErro.ForeColor = Color.Red;
                return;
            }

            double raio = Convert.ToDouble(textBoxRaio.Text);
            double resultado;

            if (radioButtonPerimetro.Checked)
            {
                resultado = raio * 2 * Math.PI;
                textBoxResultado.Text = $"{resultado: N2}";
                return;
            }
            else if (radioButtonDiametro.Checked)
            {
                resultado = raio * 2;
                textBoxResultado.Text = $"{resultado: N2}";
                return;
            }
            else if (radioButtonArea.Checked)
            {
                resultado = Math.Pow(raio, 2) * Math.PI;
                textBoxResultado.Text = $"{resultado: N2}";
                return;
            }
            else if (radioButtonVolume.Checked)
            {
                resultado = (4.0/3.0) * Math.Pow(raio, 3) * Math.PI;
                textBoxResultado.Text = $"{resultado: N2}";
                return;
            }
        }
    }
}
