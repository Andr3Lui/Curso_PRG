using Projeto_Integrador_Dominio.Dominio;


namespace Projeto_Integrador_Dominio
{
    public partial class Form_Pedido : Form
    {
        private Pedido Pedido = new();
        private Cliente Cliente = new();

        public Form_Pedido()
        {
            InitializeComponent();
        }

        public void LimparForm()
        {
            BoxBuscCliente.Clear();
            comboBoxServico.Text = "";
            comboBoxProduto.Text = "";
            numericQuantidade.Text = "";
            labelErro.Text = "";
        }

        private void Form_Pedido_Load(object sender, EventArgs e)
        {
            dataGridViewCliente.DataSource = Cliente.ListarClientes();
            dataGridViewItem.DataSource = Pedido.ListarItens();

            labelErro.Text = "";
        }

        public bool CriarPedido()
        {
            Cliente.Nome = BoxBuscCliente.Text;
            Pedido.Produto = comboBoxProduto.Text;
            Pedido.Servico = comboBoxServico.Text;
            Pedido.Quantidade = numericQuantidade.TabIndex;
            Pedido.DataDoPedido = DateTime.Now;
            Pedido.Status = Status.Pendente;

            string ValidacaoPedido = Pedido.ValidarPedido();
            if (!string.IsNullOrWhiteSpace(ValidacaoPedido))
            {
                labelErro.Text = ValidacaoPedido;
                return false;
            }

            return true;
        }
        private void buttonSelecionar_Click(object sender, EventArgs e)
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

            BoxBuscCliente.Text = Cliente.Nome;
        }

        private void buttonAdicionarItem_Click(object sender, EventArgs e)
        {
            if(comboBoxProduto.SelectedIndex != 0 || comboBoxServico.SelectedIndex != 0)
            {
                return;
            }

            Pedido.InserirItem();
            dataGridViewItem.DataSource = Pedido.ListarItens();
        }

        private void buttonConPedido_Click(object sender, EventArgs e)
        {


            if (!CriarPedido())
            {
                return;
            }

            Pedido.InserirPedido();
            LimparForm();
        }

        private void BoxBuscCliente_TextChanged(object sender, EventArgs e)
        {
            dataGridViewCliente.DataSource = Cliente.BuscarCliente(BoxBuscCliente.Text);
        }

    }
}
