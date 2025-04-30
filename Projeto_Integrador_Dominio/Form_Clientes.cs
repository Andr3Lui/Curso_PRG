using Projeto_Integrador_Dominio.Dominio;

namespace Projeto_Integrador_Dominio
{
    public partial class Form_Clientes : Form
    {
        private Cliente Cliente = new();
        private readonly BindingSource BindingSource = [];

        public Form_Clientes()
        {
            InitializeComponent();
        }

        public void LimparForm()
        {
            textBoxNome.Clear();
            textBoxEmail.Clear();
            maskedBoxCPF.Clear();
            maskedBoxTel.Clear();
            labelErro.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            labelErro.Text = "";

            BindingSource.DataSource = Cliente.ListarClientes();
            dataGridViewClientes.DataSource = BindingSource;

        }

        public bool CriarCliente()
        {
            Cliente.Nome = textBoxNome.Text;
            Cliente.Email = textBoxEmail.Text;
            Cliente.CPF = maskedBoxCPF.Text.Replace("-", "").Replace(" ", "").Replace(",", "").Replace(",", "");
            Cliente.Telefone = maskedBoxTel.Text.Replace("(", "").Replace(")", "").Replace("-", "").Replace(" ", "");

            string ValidacaoCliente = Cliente.ValidarCliente();
            if (!string.IsNullOrWhiteSpace(ValidacaoCliente))
            {
                labelErro.Text = ValidacaoCliente;
                return false;
            }
            return true;
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            if (!CriarCliente())
            {
                return;
            }

            Cliente.InserirCliente();
            BindingSource.DataSource = Cliente.ListarClientes();
            dataGridViewClientes.DataSource = BindingSource;

            LimparForm();

        }

        private void buttonEditarCliente_Click(object sender, EventArgs e)
        {
            if (dataGridViewClientes.SelectedRows.Count == 0 || dataGridViewClientes.SelectedRows[0].Index < 0)
            {
                return;
            }
        }

        private void buttonAtualizarCliente_Click(object sender, EventArgs e)
        {
            if (!CriarCliente())
            {
                return;
            }

            Cliente.EditarCliente();
            BindingSource.DataSource = Cliente.ListarClientes();
            dataGridViewClientes.DataSource = BindingSource;
        }

        private void buttonDeletarCliente_Click(object sender, EventArgs e)
        {
            if (dataGridViewClientes.SelectedRows.Count == 0 || dataGridViewClientes.SelectedRows[0].Index < 0)
            {
                return;
            }

            int id = (int)dataGridViewClientes.SelectedRows[0].Cells[0].Value;

            Cliente.RemoverCliente(id);
            
            BindingSource.DataSource = Cliente.ListarClientes();
            dataGridViewClientes.DataSource = BindingSource;
        }

        private void buttonPedidos_Click(object sender, EventArgs e)
        {
            Form_Pedido Form = new();
            Form.ShowDialog();
        }

    }
}
