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
            string raio = textBoxRaio.Text;

            labelErro.Text = "";

            if (string.IsNullOrWhiteSpace(raio) || !raio.All(char.IsNumber))
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

            if (radioButtonPerimetro.Checked)
            {
                double resultado = Convert.ToDouble(raio) * 2 * Math.PI;
                textBoxResultado.Text = resultado.ToString();
                return;
            }
            else if (radioButtonDiametro.Checked)
            {
                double resultado = Convert.ToDouble(raio) * 2;
                textBoxResultado.Text = resultado.ToString();
                return;
            }
            else if (radioButtonArea.Checked)
            {
                double resultado = Convert.ToDouble(raio) * Convert.ToDouble(raio) * Math.PI;
                textBoxResultado.Text = resultado.ToString();
                return;
            }
            else if (radioButtonVolume.Checked)
            {
                double resultado = Convert.ToDouble(raio) * Convert.ToDouble(raio) * Convert.ToDouble(raio) * (4.0 / 3.0) * Math.PI;
                textBoxResultado.Text = resultado.ToString();
                return;
            }

            textBoxRaio.Clear();
            
        }
    }
}
