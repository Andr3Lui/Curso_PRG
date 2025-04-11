using CadastrCliente.Dominio;
using MySqlX.XDevAPI;
using System.Collections.Generic;

namespace CadastrCliente
{
    public partial class Form1 : Form
    {
        private readonly Cliente Cliente = new();

        private readonly List<Cliente> clientes = [];
        private readonly BindingSource BindingSource = [];

        public Form1()
        {
            InitializeComponent();
        }

        private bool LimparLabelErro()
        {
            labelErro.Text = "";
            return true;
        }
        private bool Nome()
        {
            if (string.IsNullOrWhiteSpace(textBoxNome.Text))
            {
                labelErro.Text = "Preencha 'Nome'";
                labelErro.ForeColor = Color.Red;
                return false;
            }
            if (textBoxNome.Text.Any(char.IsNumber) || textBoxNome.Text.Any(char.IsSymbol) ||
                textBoxNome.Text.Contains('@') || textBoxNome.Text.Any(char.IsPunctuation))
            {
                labelErro.Text = "Preencha 'Nome' somente com letras";
                labelErro.ForeColor = Color.Red;
                return false;
            }
            if (!textBoxNome.Text.Contains(" "))
            {
                labelErro.Text = "Insira o Nome e Sobrenome";
                labelErro.ForeColor = Color.Red;
                return false;
            }

            return true;
        }
        private bool NomeSocial()
        {
            if (textBoxNS.Text.Any(char.IsNumber) || textBoxNS.Text.Any(char.IsSymbol) ||
                 textBoxNS.Text.Contains('@') || textBoxNS.Text.Any(char.IsPunctuation))
            {
                labelErro.Text = "Preencha 'Nome Social' somente com letras";
                labelErro.ForeColor = Color.Red;
                return false;
            }
            return true;
        }
        private bool DatadeNascimento()
        {
            if (!maskedBoxNasc.Text.Any(char.IsNumber))
            {
                labelErro.Text = "Preencha o campo 'Data de Nascimento'";
                labelErro.ForeColor = Color.Red;
                return false;

            }
            try
            {
                Convert.ToDateTime(maskedBoxNasc.Text);
            }
            catch
            {
                labelErro.Text = "Insira uma 'Data de Nascimento Válida'";
                labelErro.ForeColor = Color.Red;
                return false;
            }
            int index = 6;
            string ano = maskedBoxNasc.Text.Substring(index);
            if (Convert.ToInt32(ano) > 2025 || Convert.ToInt32(ano) < 1950)
            {
                return false;
            }


            return true;
        }
        private bool Telefone()
        {

            if (!maskedBoxNasc.Text.Any(char.IsNumber))
            {
                labelErro.Text = "Preencha Campo 'Telefone'";
                labelErro.ForeColor = Color.Red;
                return false;
            }
            if (maskedBoxTel.Text.Contains(' ') || maskedBoxTel.Text.Length < 14)
            {
                labelErro.Text = "Insira um 'Telefone' válido";
                labelErro.ForeColor = Color.Red;
                return false;
            }

            bool telefoneEncontrado = false;
            for (int i = 0; i < clientes.Count; i++)
            {
                if (clientes[i].Telefone == maskedBoxTel.Text)
                {
                    telefoneEncontrado = true;
                }
                if (telefoneEncontrado)
                {
                    labelErro.Text = "Telefone já cadastrado";
                    labelErro.ForeColor = Color.Red;
                    return false;
                }
                continue;
            }

            return true;
        }
        private bool Email()
        {



            if (string.IsNullOrWhiteSpace(textBoxEmail.Text))
            {
                labelErro.Text = "Preencha Email";
                labelErro.ForeColor = Color.Red;
                return false;
            }
            if (!textBoxEmail.Text.EndsWith("@email.com"))
            {
                labelErro.Text = "Insira um '@email.com' válido";
                labelErro.ForeColor = Color.Red;
                return false;
            }

            bool emailEncontrado = false;
            for (int i = 0; i < clientes.Count; i++)
            {
                if (clientes[i].Email == textBoxEmail.Text)
                {
                    emailEncontrado = true;

                }
                if (emailEncontrado)
                {
                    labelErro.Text = " Email já cadastrado";
                    labelErro.ForeColor = Color.Red;
                    return false;
                }
                continue;
            }
            return true;
        }
        private bool Genero()
        {
            if (comboBoxGenero.SelectedItem == null)
            {
                labelErro.Text = "selecione uma opção no Campo Gênero";
                labelErro.ForeColor = Color.Red;
                return false;
            }
            return true;
        }
        private bool Etnia()
        {
            if (comboBoxEtnia.SelectedItem == null)
            {
                labelErro.Text = "selecione uma opção no Campo Etnia";
                labelErro.ForeColor = Color.Red;
                return false;
            }
            return true;
        }
        private bool Estrangeiro()
        {
            bool estrangeiro = false;
            if (checkBoxEstrangeiro.Checked)
            {
                estrangeiro = true;
            }

            return true;
        }
        private bool Tipo()
        {
            if (!radioButtonPF.Checked && !radioButtonPJ.Checked)
            {
                labelErro.Text = "Selecione entre 'PF' ou 'PJ'";
                labelErro.ForeColor = Color.Red;
                return false;
            }
            return true;
        }
        private bool Logradouro()
        {
            if (string.IsNullOrWhiteSpace(textBoxLogradouro.Text))
            {
                labelErro.Text = "Preencha 'Logradouro'";
                labelErro.ForeColor = Color.Red;
                return false;
            }
            if (textBoxLogradouro.Text.All(char.IsNumber) || textBoxLogradouro.Text.Any(char.IsSymbol) ||
                textBoxLogradouro.Text.Contains("@") || textBoxLogradouro.Text.Any(char.IsPunctuation) ||
                !textBoxLogradouro.Text.Contains(' '))
            {
                labelErro.Text = "Preencha 'Logradouro' válido";
                labelErro.ForeColor = Color.Red;
                return false;
            }
            return true;
        }
        private bool Numero()
        {
            if (string.IsNullOrWhiteSpace(textBoxNumero.Text))
            {
                labelErro.Text = "Preencha o Campo 'Número'";
                labelErro.ForeColor = Color.Red;
                return false;
            }
            if (textBoxNumero.Text.All(char.IsLetter))
            {
                labelErro.Text = "Não é possível preencher o Campo 'Número' somente com letras";
                labelErro.ForeColor = Color.Red;
                return false;
            }
            if (textBoxNumero.Text.Any(char.IsPunctuation) || textBoxNumero.Text.Any(char.IsSymbol)
                || textBoxNumero.Text.Contains('@'))
            {
                labelErro.Text = "Insira um 'número' válido";
                labelErro.ForeColor = Color.Red;
                return false;
            }

            return true;
        }
        private bool Bairro()
        {
            if (string.IsNullOrWhiteSpace(textBoxBairro.Text))
            {
                labelErro.Text = "Preencha o Campo 'Bairro'";
                labelErro.ForeColor = Color.Red;
                return false;
            }
            if (textBoxLogradouro.Text.All(char.IsNumber) || textBoxLogradouro.Text.Any(char.IsSymbol) ||
                 textBoxLogradouro.Text.Contains('@') || textBoxLogradouro.Text.Any(char.IsPunctuation))
            {
                labelErro.Text = "Preencha 'Bairro' válido";
                labelErro.ForeColor = Color.Red;
                return false;
            }
            return true;
        }
        private bool Municipio()
        {
            if (string.IsNullOrWhiteSpace(textBoxMunicipio.Text))
            {
                labelErro.Text = "Preencha o Campo 'Municipio'";
                labelErro.ForeColor = Color.Red;
                return false;
            }
            if (!textBoxMunicipio.Text.Any(char.IsLetter))
            {
                labelErro.Text = "Preencha o Campo 'Municipio' somente com letras";
                labelErro.ForeColor = Color.Red;
                return false;
            }

            return true;
        }
        private bool Estado()
        {
            if (comboBoxEstado.SelectedItem == null)
            {
                labelErro.Text = "Selecione seu Estado";
                labelErro.ForeColor = Color.Red;
                return false;
            }

            return true;
        }
        private bool CEP()
        {
            if (!maskedBoxCep.Text.Any(char.IsNumber))
            {
                labelErro.Text = "Preencha Campo 'CEP'";
                labelErro.ForeColor = Color.Red;
                return false;
            }
            if (maskedBoxCep.Text.Contains(' ') || maskedBoxCep.Text.Length < 9)
            {
                labelErro.Text = "Insira um 'CEP' válido";
                labelErro.ForeColor = Color.Red;
                return false;
            }
            return true;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            BindingSource.DataSource = Cliente.ListarClientes();
            dataGridViewClientes.DataSource = BindingSource;
        }
        private void buttonCadastrar_Click(object sender, EventArgs e)
        {

            if (!LimparLabelErro())
            {
                return;
            }

            //
            //Informações Pessoais
            //
            if (!Nome())
            {
                return;
            }
            if (!NomeSocial())
            {
                return;
            }
            if (!DatadeNascimento())
            {
                return;
            }
            if (!Telefone())
            {
                return;
            }
            if (!Email())
            {
                return;
            }
            if (!Genero())
            {
                return;
            }
            if (!Etnia())
            {
                return;
            }
            if (!Estrangeiro())
            {
                return;
            }
            if (!Tipo())
            {
                return;
            }
            //
            //Endereço
            //
            if (!Logradouro())
            {
                return;
            }
            if (!Numero())
            {
                return;
            }
            if (!Bairro())
            {
                return;
            }
            if (!Municipio())
            {
                return;
            }
            if (!Estado())
            {
                return;
            }
            if (!CEP())
            {
                return;
            }



            

            TipoCliente tipo = 0;
            if (radioButtonPF.Checked)
            {
                tipo = TipoCliente.PF;
            }
            if (radioButtonPJ.Checked)
            {
                tipo = TipoCliente.PJ;
            }

            EnderecoCliente endereco = new()
            {
                Logradouro = textBoxLogradouro.Text,
                Numero = textBoxNumero.Text,
                Complemento = textBoxComple.Text,
                Bairro = textBoxBairro.Text,
                Municipio = textBoxMunicipio.Text,
                Estado = comboBoxEstado.Text,
                CEP = maskedBoxCep.Text.Replace("-", ""),
            };

            DateTime.TryParse(maskedBoxNasc.Text, out DateTime dataNascimento);

            Cliente novoCliente = new()
            {
                Nome = textBoxNome.Text,
                DataNascimento = dataNascimento,
                Telefone = maskedBoxTel.Text.Replace("(","").Replace(")","").Replace("-","").Replace(" ",""),
                Email = textBoxEmail.Text,
                Endereco = endereco,
                Genero = (GeneroCliente)comboBoxGenero.SelectedIndex,
                Estrangeiro = checkBoxEstrangeiro.Checked,
                Etnia = (EtniaCliente)comboBoxEtnia.SelectedIndex,
                NomeSocial = textBoxNS.Text,
                Tipo = tipo
            };


            labelErro.Text = "Cliente Cadastrado com Sucesso";
            labelErro.ForeColor = Color.Green;

            novoCliente.InserirCliente(novoCliente);
            BindingSource.DataSource = Cliente.ListarClientes();
            BindingSource.ResetBindings(false);



        }

    }
}
