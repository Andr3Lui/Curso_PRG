using System.Runtime.Intrinsics.X86;

namespace CadastrCliente
{
    public partial class Form1 : Form
    {
        List<Cliente> clientes = new List<Cliente>();
        public Form1()
        {
            InitializeComponent();
            EnderecoCliente endereco = new EnderecoCliente() { Logradouro = "Rua do Jacaraí", Numero = "974", Complemento = " ", Bairro = "Fernando de Aquino", Municipio = "Beruri", Estado = "AM", CEP = "08556-920" };
            clientes.Add(new Cliente() { Id = 1, Nome = "Barbara Reali", DataNascimento = "03/07/2005", Telefone = "(11)94459-7865", Email = "B4rbar!@email.com", Endereco = endereco, Genero = GeneroCliente.Feminino, Estrangeiro = false, Etnia = EtniaCliente.Indigena, NomeSocial = " ", Tipo = TipoCliente.PF });

            EnderecoCliente endereco2 = new EnderecoCliente() { Logradouro = "Av. Brasil", Numero = "78", Complemento = "Ao Lado da Igreja da Penha", Bairro = "Penha", Municipio = "Madureira", Estado = "RJ", CEP = "09563-451" };
            clientes.Add(new Cliente() { Id = 2, Nome = "Pedro Nascimento", DataNascimento = "26/04/1998", Telefone = "(11)97884-2341", Email = "P&dr0Nasc@email.com", Endereco = endereco2, Genero = GeneroCliente.Masculino, Estrangeiro = false, Etnia = EtniaCliente.Preto, NomeSocial = " ", Tipo = TipoCliente.PF });

            EnderecoCliente endereco3 = new EnderecoCliente() { Logradouro = "Rua ", Numero = "14", Complemento = "Bloco C", Bairro = "Jd. Macedonia", Municipio = "Itapecerica da Serra", Estado = "SP", CEP = "05823-659" };
            clientes.Add(new Cliente() { Id = 3, Nome = "Sukuna Nakima", DataNascimento = "30/01/2000", Telefone = "(11)94567-8512", Email = "Sukuna77#@email.com", Endereco = endereco3, Genero = GeneroCliente.Masculino, Estrangeiro = true, Etnia = EtniaCliente.Amarelo, NomeSocial = "Paulo Silva", Tipo = TipoCliente.PJ });

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
                labelErro.Text = "Preencha Nome";
                labelErro.ForeColor = Color.Red;
                return false;
            }
            if (!textBoxNome.Text.All(char.IsLetter))
            {
                labelErro.Text = "Preencha somente com letras";
                labelErro.ForeColor = Color.Red;
                return false;
            }

            return true;
        }
        private bool NomeSocial()
        {
            if (!textBoxNS.Text.All(char.IsLetter))
            {
                labelErro.Text = "Preencha somente com letras";
                labelErro.ForeColor = Color.Red;
                return false;
            }
            return true;
        }
        private bool DatadeNascimento()
        {
            if(string.IsNullOrWhiteSpace(maskedBoxNasc.Text))
            {
                labelErro.Text = "Preencha Campo 'Data de Nascimento'";
                labelErro.ForeColor = Color.Red;
                return false;
            }
            
            return true;
        }
        private bool Telefone()
        {
            if (string.IsNullOrWhiteSpace(maskedBoxTel.Text))
            {
                labelErro.Text = "Preencha Campo 'Telefone'";
                labelErro.ForeColor = Color.Red;
                return false;
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
            if (textBoxEmail.Text.EndsWith("@email.com"))
            {
                labelErro.Text = "Email deve conter (@email.com)";
                labelErro.ForeColor = Color.Red;
                return false;
            }
            if(textBoxEmail.Text.Length >= 18)
            {
                labelErro.Text = "Email deve conter ao menos 8 caracteres";
                labelErro.ForeColor = Color.Red;
                return false;

            }
            return true;
        }
        private bool Genero()
        {
            if(comboBoxGenero.SelectedItem == null)
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
            if (checkBoxEstrangeiro.Checked)
            {
                return false;
            }
            else
            {
                return true;
            }
            
        }
        private bool Tipo()
        {
            if (!radioButtonPF.Checked && !radioButtonPJ.Checked)
            {
                labelErro.Text = "Selecione entre PF ou PJ";
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
            if (!textBoxBairro.Text.Any(char.IsLetter))
            {
                labelErro.Text = "Preencha o Campo 'Bairro' somente com letras";
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
            return true;
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
           
            if(!LimparLabelErro())
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



            labelErro.Text = "Cadastrado com Sucesso";
            labelErro.ForeColor = Color.Green; 
           
        }
    }
}
