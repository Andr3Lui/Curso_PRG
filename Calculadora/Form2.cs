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
                labelNotificacao.Text = "Insira um valor válido";
                labelNotificacao.ForeColor = Color.Red;
                return;
            }

            if (valor1 == 0)

            {
                labelNotificacao.Text = "Insira um valor maior que zero";
                labelNotificacao.ForeColor = Color.Red;
                return;
            }

            if (comboBoxOperacoes.SelectedItem == null)
            {
                labelNotificacao.Text = "selecione uma operação";
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


            }

            textBoxResultado.Text = resultado1.ToString();
            textBoxn1.Clear();
            labelNotificacao.Text = "";
        }

        private void botaoCalcular_Click(object sender, EventArgs e)
        {
            double comprimento, largura, altura = 0, resultado2 = 0;


            if (!double.TryParse(textBoxComprimento.Text, out comprimento) || comprimento <= 0)
            {
                labelNotificacao2.Text = "Insira um valor válido em comprimento";
                labelNotificacao2.ForeColor = Color.Red;
                return;
            }

            if (!double.TryParse(textBoxLargura.Text, out largura) || largura <= 0)
            {
                labelNotificacao2.Text = "Insira um valor válido em largura";
                labelNotificacao2.ForeColor = Color.Red;
                return;
            }

            if (comboBoxOperacoes2.SelectedText.ToString() == "Volume")
            {
                if (!double.TryParse(textBoxAltura.Text, out altura) || altura <= 0)
                {
                    labelNotificacao2.Text = "Insira um valor válido em altura";
                    labelNotificacao2.ForeColor = Color.Red;
                    return;
                }
            }

            if (comboBoxOperacoes2.SelectedItem == null)
            {
                labelNotificacao2.Text = "selecione uma operação";
                labelNotificacao2.ForeColor = Color.Red;
                return;
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


            }

            boxResultado.Text = resultado2.ToString();
            textBoxComprimento.Clear();
            textBoxLargura.Clear();
            textBoxAltura.Clear();
            labelNotificacao2.Text = "";

        }

        private void comboBoxOperacoes2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxOperacoes2.SelectedItem?.ToString() == "Volume")
            {
                textBoxAltura.Enabled = true;
            }
            else
            {
                textBoxAltura.Enabled = false;
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Form3 forms3 = new Form3();
            forms3.ShowDialog();
        }
    }
} 
      

