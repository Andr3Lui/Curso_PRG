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
        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            labelErro.Text = "";
            //nome
            if (string.IsNullOrWhiteSpace(textBoxNome.Text))
            {
                labelErro.Text = "Preencha Nome";
                labelErro.ForeColor = Color.Red;
                return;
            }
            if (!textBoxNome.Text.All(char.IsLetter))
            {
                labelErro.Text = "Preencha somente com letras";
                labelErro.ForeColor = Color.Red;
                return;
            }
            /*
            //Data de Nascimento
            if (string.IsNullOrWhiteSpace(maskedBoxNasc.Text))
            {
                labelErro.Text = "Preencha Data de Nascimento";
                labelErro.ForeColor = Color.Red;
                return;
            }
            //Email
            if (string.IsNullOrWhiteSpace(textBoxEmail.Text))
            {
                labelErro.Text = "Preencha Email";
                labelErro.ForeColor = Color.Red;
                return;
            }
            if (string.IsNullOrWhiteSpace(textBoxEmail.Text))
            {
                labelErro.Text = "Preencha Email";
                labelErro.ForeColor = Color.Red;
                return;
            }

            if (string.IsNullOrWhiteSpace(textBoxNome.Text))
            {
                labelErro.Text = "Preencha nome";
                labelErro.ForeColor = Color.Red;
                return;
            }
            if (string.IsNullOrWhiteSpace(textBoxNome.Text))
            {
                labelErro.Text = "Preencha nome";
                labelErro.ForeColor = Color.Red;
                return;
            }
            if (string.IsNullOrWhiteSpace(textBoxNome.Text))
            {
                labelErro.Text = "Preencha nome";
                labelErro.ForeColor = Color.Red;
                return;
            }
            if (string.IsNullOrWhiteSpace(textBoxNome.Text))
            {
                labelErro.Text = "Preencha nome";
                labelErro.ForeColor = Color.Red;
                return;
            }
            if (string.IsNullOrWhiteSpace(textBoxNome.Text))
            {
                labelErro.Text = "Preencha nome";
                labelErro.ForeColor = Color.Red;
                return;
            }
            */
        }
    }
}
