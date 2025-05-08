using Projeto_Integrador_Dominio.Dominio;


namespace Projeto_Integrador_Dominio
{
    public partial class Form_Pedido : Form
    {
        private readonly BindingSource BindingSource = [];
        private Pedido Pedido = new();
        private Cliente Cliente = new();
        private Produto Produto = new();
        private Servico Servico = new();

        public Form_Pedido()
        {
            InitializeComponent();
        }

        public void LimparForm()//Feito
        {
            BoxBuscCliente.Clear();
            textBoxProduto.Text = "";
            textBoxServico.Text = "";
            numericQuantidade.Text = "";
            labelErro.Text = "";
        }

        private void Form_Pedido_Load(object sender, EventArgs e)
        {
            labelErro.Text = "";

            dataGridViewCliente.DataSource = Cliente.ListarClientes();
            dataGridViewServico.DataSource = Pedido.ListarServico();
            dataGridViewProduto.DataSource = Pedido.ListarProduto();
        }

        public bool CriarPedido()//Feito
        {
            Cliente.Nome = BoxBuscCliente.Text;
            Produto.Nome = textBoxProduto.Text;
            Servico.Nome = textBoxServico.Text;
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

        private void buttonSelecionar_Click(object sender, EventArgs e)//Incompleto
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


            dataGridViewItem.DataSource = Pedido.ListarItem();

        } //Incompleto

        private void buttonConPedido_Click(object sender, EventArgs e) //Feito
        {
            if (!CriarPedido())
            {
                return;
            }

            Pedido.InserirPedido();
            LimparForm();
        }

        private void BoxBuscCliente_TextChanged(object sender, EventArgs e)//Feito
        {
            dataGridViewCliente.DataSource = Cliente.BuscarCliente(BoxBuscCliente.Text);
        }

        private void textBoxProduto_TextChanged(object sender, EventArgs e)//Feito
        {
            dataGridViewProduto.DataSource = Pedido.BuscarProduto(textBoxProduto.Text);
        }

        private void textBoxServico_TextChanged(object sender, EventArgs e)//Feito
        {
            dataGridViewServico.DataSource = Pedido.BuscarServico(textBoxServico.Text);
        }
    }
}
