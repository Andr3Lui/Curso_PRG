using Projeto_Integrador_Dominio.Dominio;


namespace Projeto_Integrador_Dominio
{
    public partial class Form_Pedido : Form
    {
        private readonly BindingSource BindingSource = [];
        private Pedido Pedido = new();

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
            BindingSource.DataSource = Pedido.ListarItem();
            dataGridViewItem.DataSource = BindingSource;

            labelErro.Text = "";
        }

        public bool CriarPedido()
        {
            Pedido.Cliente.Nome = BoxBuscCliente.Text; 
            Pedido.Produto = (Produto)comboBoxProduto.SelectedIndex;
            Pedido.Servico = (Servico)comboBoxServico.SelectedIndex;
            Pedido.Quantidade = numericQuantidade.TabIndex;
            Pedido.DataDoPedido = DateTime.Now;
            Pedido.Status = Status.Pendente;
            Pedido.Pagamento = (Pagamento)comboBoxPagamento.SelectedIndex;

            string ValidacaoPedido = Pedido.ValidarPedido();
            if (!string.IsNullOrWhiteSpace(ValidacaoPedido))
            {
                labelErro.Text = ValidacaoPedido;
                return false;
            }

            return true;
        }

        private void buttonAdicionarItem_Click(object sender, EventArgs e)
        {
            

        }



        private void buttonBuscar_Click(object sender, EventArgs e)
        {


        }

        private void buttonConPedido_Click(object sender, EventArgs e)
        {
            if (!CriarPedido())
            {
                return;
            }

            Pedido.InserirPedido();
            BindingSource.DataSource = Pedido.ListarPedidosPendentes();
            //dataGridViewPedidos.DataSource = BindingSource;

            LimparForm();
        }
    }
}
