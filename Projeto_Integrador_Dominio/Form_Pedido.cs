using Projeto_Integrador_Dominio.Dominio;


namespace Projeto_Integrador_Dominio
{
    public partial class Form_Pedido : Form
    {

        private Pedido Pedido = new();

        public Form_Pedido()
        {
            InitializeComponent();
        }

        public void LimparForm()
        {
            BoxBuscCliente.Clear();
            comboBoxServiço.Text = "";
            comboBoxProduto.Text = "";
            numericQuantidade.Text = "";
            labelErro.Text = "";
        }
        private void Form_Pedido_Load(object sender, EventArgs e)
        {
            labelErro.Text = "";
        }
        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            
        }
        private void buttonConPedido_Click(object sender, EventArgs e)
        {

            Pedido.Cliente = Cliente.BoxBuscCliente.
            Pedido.Servico = (Servico)comboBoxServiço.SelectedIndex;
            Pedido.Produto = (Produto)comboBoxProduto.SelectedIndex;
            Pedido.Quantidade = numericQuantidade.Text; 

            LimparForm();
        }
    }
}
