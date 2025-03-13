using System;
using System.Buffers;
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
            double valor1, resultado1 = 0;

            if (!double.TryParse(textBoxn1.Text, out valor1))
            {
                labelNotificacao.Text = "Insira um valor";
                labelNotificacao.ForeColor = Color.Red;
                return;
            }

            if (valor1 == 0)

            {
                labelNotificacao.Text = "Insira um valor maior que zero";
                labelNotificacao.ForeColor = Color.Red;
                return;
            }

            switch (comboBoxOperacoes.SelectedItem.ToString())
            {
                case "Perímetro":
                    resultado1 = valor1 * 4;
                    break;

                case "Área":
                    resultado1 = valor1 * valor1;
                    break;

                case "Volume":
                    resultado1 = Math.Pow(valor1, 3);
                    break;

                default:
                    labelNotificacao.Text = "Selecione uma operação";
                    labelNotificacao.ForeColor = Color.Red;
                    break;

            }

            textBoxResultado.Text = resultado1.ToString();
            textBoxn1.Clear();
        }

        private void botaoCalcular_Click(object sender, EventArgs e)
        {
            double comprimento, largura, altura = 0, resultado2 = 0;
            bool volume = false;

            if (!double.TryParse(textBoxComprimento.Text, out comprimento) || comprimento <= 0)
            {
                labelNotificacao.Text = "Insira um valor";
                labelNotificacao.ForeColor = Color.Red;
                return;
            }
            if (!double.TryParse(textBoxLargura.Text, out largura) || largura <= 0)
            {
                labelNotificacao.Text = "Insira um valor";
                labelNotificacao.ForeColor = Color.Red;
                return;
            }

            if (comboBoxOperacoes2.SelectedItem.ToString() == "Volume")
            {
                volume = true;
                if (!double.TryParse(textBoxAltura.Text, out altura) || altura <= 0)
                {
                    labelNotificacao.Text = "Insira um valor";
                    labelNotificacao.ForeColor = Color.Red;
                    return;
                }

            }

            switch (comboBoxOperacoes2.SelectedItem.ToString())
            {
                case "Perímetro":
                    resultado2 = 2 * (comprimento + largura);
                    break;

                case "Área":
                    resultado2 = comprimento * largura;
                    break;

                case "Volume":
                    resultado2 = comprimento * largura * altura;
                    break;

                default:
                    labelNotificacao.Text = "Selecione uma operação";
                    labelNotificacao.ForeColor = Color.Red;
                    return;

            }

            boxResultado.Text = resultado2.ToString();
            textBoxComprimento.Clear();
            textBoxLargura.Clear();
            textBoxAltura.Clear();

        }

        private void opcoesFormas2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (opcoesFormas.SelectedItem.ToString() == "Paralelepipedo" && opcoesFormas.SelectedItem != null)
            {
                textBoxAltura.Enabled = true;
                comboBoxOperacoes2.SelectedItem = "Volume";
            }
            else
            {
                textBoxAltura.Enabled = false;
                comboBoxOperacoes2.SelectedItem = ("Perímetro", "Área");
            }
        }
    }
} 
      

