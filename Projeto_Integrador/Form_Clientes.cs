using Projeto_Integrador_Dominio.Dominio;
using System.Runtime.InteropServices;

namespace Projeto_Integrador_Dominio
{
    public partial class Form_Clientes : Form
    {
        private Cliente Cliente = new();

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

            dataGridViewCliente.DataSource = Cliente.ListarClientes();

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
                labelErro.ForeColor = Color.Red;
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
            dataGridViewCliente.DataSource = Cliente.ListarClientes();

            LimparForm();

        }

        private void buttonEditarCliente_Click(object sender, EventArgs e)
        {
            if (dataGridViewCliente.SelectedRows.Count == 0 || dataGridViewCliente.SelectedRows[0].Index < 0)
            {
                return;
            }

            int id = (int)dataGridViewCliente.SelectedRows[0].Cells[0].Value;
            var cliente = Cliente.BuscarID(id);

            if (cliente == null)
            {
                return;
            }

            Cliente = cliente;

            textBoxNome.Text = Cliente.Nome;
            textBoxEmail.Text = Cliente.Email;
            maskedBoxCPF.Text = Cliente.CPF;
            maskedBoxTel.Text = Cliente.Telefone;
        }

        private void buttonAtualizarCliente_Click(object sender, EventArgs e)
        {
            if (!CriarCliente())
            {
                return;
            }

            Cliente.EditarCliente();
            dataGridViewCliente.DataSource = Cliente.ListarClientes();
        }

        private void buttonDeletarCliente_Click(object sender, EventArgs e)
        {
            if (dataGridViewCliente.SelectedRows.Count == 0 || dataGridViewCliente.SelectedRows[0].Index < 0)
            {
                return;
            }

            int id = (int)dataGridViewCliente.SelectedRows[0].Cells[0].Value;
            Cliente.RemoverCliente(id);

            dataGridViewCliente.DataSource = Cliente.ListarClientes();
        }

        private void buttonBuscarCliente_Click(object sender, EventArgs e)
        {
            dataGridViewCliente.DataSource = Cliente.BuscarCliente(textBoxBuscar.Text);
        }

        private void textBoxBuscar_TextChanged(object sender, EventArgs e)
        {
            dataGridViewCliente.DataSource = Cliente.BuscarCliente(textBoxBuscar.Text);
        }

        private void buttonPedidos_Click(object sender, EventArgs e)
        {
            HairSharp Form = new();
            Form.Show();
            this.Hide();
        }

        
    }
}
