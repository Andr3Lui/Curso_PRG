namespace Calculadora
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double valor1, valor2, resultado = 0;

            if (!double.TryParse(textBoxn1.Text, out valor1))
            {
                labelResultado.Text = "O valor 1 deve ser um número";
                labelResultado.ForeColor = Color.Red;
                return;
            }
            if (!double.TryParse(textBoxn2.Text, out valor2))
            {
                labelResultado.Text = "O valor 2 deve ser um número";
                labelResultado.ForeColor = Color.Red;
                return;
            }

            switch (comboBoxOperacoes.SelectedItem?.ToString())
            {
                case "+":
                    resultado = valor1 + valor2;
                    return;
                case "-":
                    resultado = valor1 - valor2;
                    return;
                case "*":
                    resultado = valor1 * valor2;
                    return;
                case "/":
                    resultado = valor1 / valor2;
                    if (valor2 != 0)
                    {
                        resultado = valor1 / valor2;
                    }
                    else
                    {
                        labelResultado.Text = "Erro: Não é possivel dividir por zero";
                        labelResultado.ForeColor = Color.Red;
                    }
                    return;


                default:
                    labelResultado.Text = "Selecione uma Operação";
                    labelResultado.ForeColor = Color.Red;
                    break;


            }

            labelResultado.ForeColor = Color.Black;
            labelResultado.Text = resultado.ToString();
            textBoxn1.Clear();
            textBoxn2.Clear();
        }   
    }
}
