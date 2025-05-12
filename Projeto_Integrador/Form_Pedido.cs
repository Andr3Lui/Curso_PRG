using Mysqlx;
using Projeto_Integrador_Dominio.Dominio;


namespace Projeto_Integrador_Dominio
{
    public partial class HairSharp : Form
    {
        private Cliente Cliente = new();
        private Pedido Pedido = new();

        private List<Produto> Produtos = [];
        private List<Servico> Servicos = [];

        private List<PedidoItem> itensSelecionados = [];

        public HairSharp()
        {
            InitializeComponent();
        }

        public void LimparForm()//Feito
        {
            BoxBuscCliente.Clear();
            textBoxProduto.Text = "";
            textBoxServico.Text = "";
            numericQuantidade.Value = 0;
            labelErro.Text = "";

            itensSelecionados.Clear();
            AtualizarItems();
        }

        private void AtualizarItems() //OK
        {
            labelErro.Text = "";
            textBoxValorTotal.Text = $"R$ {CalcularValorPedido()}";

            dataGridViewItem.DataSource = null;
            dataGridViewItem.DataSource = itensSelecionados;
        }

        private void Form_Pedido_Load(object sender, EventArgs e) //OK
        {
            labelErro.Text = "";

            dataGridViewCliente.DataSource = Cliente.ListarClientes();

            Servicos = Pedido.ListarServico();
            dataGridViewServico.DataSource = Servicos;

            Produtos = Pedido.ListarProduto();
            dataGridViewProduto.DataSource = Produtos;
        }

        private decimal CalcularValorPedido()//OK
        {
            decimal valor = 0;

            itensSelecionados.ForEach(item =>
            {
                if (item.IdProduto != null)
                {
                    var produto = Produtos.Find(produto => produto.Id == item.IdProduto);
                    if (produto != null && item.Quantidade != null)
                    {
                        valor += produto.Valor * ((int)item.Quantidade);
                    }

                    return;
                }

                if (item.IdServico != null)
                {
                    var servico = Servicos.Find(servico => servico.Id == item.IdServico);
                    if (servico != null)
                    {
                        valor += servico.Valor;
                    }

                    return;
                }

            });

            return valor;
        }

        private bool CriarPedido()//OK
        {
            Pedido.Valor = CalcularValorPedido();
            Pedido.Pagamento = (Pagamento)comboBoxFormasPagamento.SelectedIndex;
            Pedido.DataDoPedido = DateTime.Now;

            Pedido.Cliente = Cliente;

            string ValidacaoPedido = Pedido.ValidarPedido();
            if (!string.IsNullOrWhiteSpace(ValidacaoPedido))
            {
                labelErro.Text = ValidacaoPedido;
                labelErro.ForeColor = Color.Red;
                return false;
            }

            return true;
        }

        private void buttonSelecionar_Click(object sender, EventArgs e)//OK
        {
            if (dataGridViewCliente.SelectedRows.Count == 0 || dataGridViewCliente.SelectedRows[0].Index < 0)
            {
                labelErro.Text = "Selecione um 'Cliente'.";
                labelErro.ForeColor = Color.Red;
                return;
            }

            int id = (int)dataGridViewCliente.SelectedRows[0].Cells[0].Value;
            var cliente = Cliente.BuscarID(id);

            if (cliente == null)
            {
                return;
            }

            Cliente = cliente;

            labelClienteSelecionado.Text = $"Cliente selecionado: {Cliente.Nome}";
            labelClienteSelecionado.ForeColor = Color.Blue;
        }

        private void buttonConPedido_Click(object sender, EventArgs e)//OK
        {
            if (!CriarPedido())
            {
                return;
            }

            Pedido.InserirPedido(itensSelecionados);
            LimparForm();
        }

        private void buttonAdicionarServico_Click(object sender, EventArgs e)//OK
        {
            if (dataGridViewServico.SelectedRows.Count == 0 || dataGridViewServico.SelectedRows[0].Index < 0)
            {
                labelErro.Text = "Selecione um 'Servico'.";
                labelErro.ForeColor = Color.Red;
                return;
            }

            var id = (int)dataGridViewServico.SelectedRows[0].Cells[0].Value;

            itensSelecionados.Add(new PedidoItem()
            {
                IdServico = id,
            });

            AtualizarItems();
        }

        private void buttonAdicionarItem_Click(object sender, EventArgs e)//OK
        {
            if (dataGridViewProduto.SelectedRows.Count == 0 || dataGridViewProduto.SelectedRows[0].Index < 0)
            {
                labelErro.Text = "Selecione um 'Produto'.";
                labelErro.ForeColor = Color.Red;
                return;
            }

            if (numericQuantidade.Value <= 0)
            {
                labelErro.Text = "A quantidade do 'Produto' deve ser maior que zero.";
                labelErro.ForeColor = Color.Red;
                return;
            }

            var id = (int)dataGridViewProduto.SelectedRows[0].Cells[0].Value;
            var qtd = (int)numericQuantidade.Value;

            itensSelecionados.Add(new PedidoItem()
            {
                IdProduto = id,
                Quantidade = qtd
            });

            AtualizarItems();
        }

        private void buttonRemoverItem_Click(object sender, EventArgs e)//OK
        {
            if (dataGridViewItem.SelectedRows.Count == 0 || dataGridViewItem.SelectedRows[0].Index < 0)
            {
                labelErro.Text = "Selecione um 'Item' lista.";
                labelErro.ForeColor = Color.Red;
                return;
            }

            var servicoId = dataGridViewItem.SelectedRows[0].Cells[1]?.Value;
            var produtoId = dataGridViewItem.SelectedRows[0].Cells[2]?.Value;

            if (servicoId != null)
            {
                itensSelecionados.RemoveAt(itensSelecionados.FindIndex(i => i.IdServico == (int)servicoId));
            }

            if (produtoId != null)
            {
                itensSelecionados.RemoveAt(itensSelecionados.FindIndex(i => i.IdProduto == (int)produtoId));
            }

            AtualizarItems();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)//OK
        {
            Form_Clientes f = new Form_Clientes();
            f.Show();
            this.Hide();
        }

        private void BoxBuscCliente_TextChanged(object sender, EventArgs e)//OK
        {
            dataGridViewCliente.DataSource = Cliente.BuscarCliente(BoxBuscCliente.Text);
        }

        private void textBoxProduto_TextChanged(object sender, EventArgs e)//OK
        {
            dataGridViewProduto.DataSource = Pedido.BuscarProduto(textBoxProduto.Text);
        }

        private void textBoxServico_TextChanged(object sender, EventArgs e)//OK
        {
            dataGridViewServico.DataSource = Pedido.BuscarServico(textBoxServico.Text);
        }

        
    }
}
