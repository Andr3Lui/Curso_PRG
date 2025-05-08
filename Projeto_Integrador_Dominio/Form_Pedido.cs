using Projeto_Integrador_Dominio.Dominio;


namespace Projeto_Integrador_Dominio
{
    public partial class Form_Pedido : Form
    {
        private readonly BindingSource BindingSource = [];
        private Pedido Pedido = new();
        private Produto Produto = new();
        private Servico Servico = new();
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
            labelErro.Text = "";

            dataGridViewCliente.DataSource = Cliente.ListarClientes();
            dataGridViewItem.DataSource = Pedido.ListarItem();
        }

        public bool CriarPedido()
        {
            Cliente.Nome = BoxBuscCliente.Text;
            Produto.Nome = comboBoxProduto.Text;
            Servico.Nome = comboBoxServico.Text;
            Pedido.Quantidade = numericQuantidade.TabIndex;
            Pedido.DataDoPedido = DateTime.Now;
            Pedido.Estado = Estado.Pendente;

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
            if (comboBoxProduto.SelectedIndex <= 0)
            {
                return;
            }

            //Pedido.InserirProduto();

            if (comboBoxServico.SelectedIndex <= 0)
            {
                return;
            }

            //Pedido.InserirServico();

            dataGridViewItem.DataSource = Pedido.ListarItem();

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

        private void comboBoxServico_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridViewServico.DataSource = Pedido.listarProduto(comboBoxServico.Text);
        }

        private void comboBoxProduto_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridViewServico.DataSource = Pedido.listarProduto(comboBoxProduto.Text);
        }
    }
}
