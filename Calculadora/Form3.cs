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
            //Diâmetro
            string raio = textBoxRaio.Text;

            labelErro.Text = "";

            if (string.IsNullOrWhiteSpace(raio) || !raio.All(char.IsNumber))
            {
                labelErro.Text = "Insira um valor válido";
                labelErro.ForeColor = Color.Red;    
            }

            double resultado = Convert.ToDouble(raio) * 2;
            textBoxResultado.Text = resultado.ToString();
        }
    }
}
