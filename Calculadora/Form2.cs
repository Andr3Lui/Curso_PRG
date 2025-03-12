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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double valor1, resultado = 0;
          
            if (!double.TryParse(textBoxn1.Text, out valor1))
            {
                labelNotificacao.Text = "Insira o primero valor";
                labelNotificacao.ForeColor = Color.Red;
                return;
            }
           
            switch (comboBoxOperacoes.SelectedItem.ToString())
            {
                case "Perímetro":
                    resultado = valor1 * 4;
                    break;

                case "Área":
                    resultado = valor1 * valor1;
                    break;

                case "Volume":
                    resultado = Math.Pow(valor1, 3);
                    break;
            }

            textBoxResultado.Text = resultado.ToString();


        }
    }
} 

