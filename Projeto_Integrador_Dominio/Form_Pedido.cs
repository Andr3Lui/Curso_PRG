using Projeto_Integrador_Dominio.Dominio;


namespace Projeto_Integrador_Dominio
{
    public partial class Form_Pedido : Form
    {
        private Cliente Cliente = new();
        private Pedido Pedido = new();

        private List<Produto> Produtos = [];
        private List<Servico> Servicos = [];

        private List<PedidoItem> itensSelecionados = [];

        public Form_Pedido()
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

        private void AtualizarItems()
        {
            labelErro.Text = "";
            labelValorTotal.Text = $"Valor total: R$ {CalcularValorPedido()}";

            dataGridViewItem.DataSource = null;
            dataGridViewItem.DataSource = itensSelecionados;
        }

        private void Form_Pedido_Load(object sender, EventArgs e) //Feito
        {
            labelErro.Text = "";

            dataGridViewCliente.DataSource = Cliente.ListarClientes();

            Servicos = Pedido.ListarServico();
            dataGridViewServico.DataSource = Servicos;

            Produtos = Pedido.ListarProduto();
            dataGridViewProduto.DataSource = Produtos;
        }

        private decimal CalcularValorPedido()
        {
            decimal valor = 0;

            itensSelecionados.ForEach(item => 
            {
                if (item.IdProduto != null)
                {
                    var produto = Produtos.Find(produto => produto.Id == item.IdProduto);
                    if (produto != null && item.Quantidade != null)
                    {
                        valor += produto.Valor * ((int) item.Quantidade);
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

        private bool CriarPedido() //OK
        {
            Pedido.Valor = CalcularValorPedido();
            Pedido.DataDoPedido = DateTime.Now;
            Pedido.Estado = Estado.Pendente;
            Pedido.Cliente = Cliente;

            string ValidacaoPedido = Pedido.ValidarPedido();
            if (!string.IsNullOrWhiteSpace(ValidacaoPedido))
            {
                labelErro.Text = ValidacaoPedido;
                return false;
            }

            return true;
        }

        private void buttonSelecionar_Click(object sender, EventArgs e)//Feito
        {
            if (dataGridViewCliente.SelectedRows.Count == 0 || dataGridViewCliente.SelectedRows[0].Index < 0)
            {
                labelErro.Text = "Selecione um 'Cliente'.";
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
        }

        private void buttonConPedido_Click(object sender, EventArgs e)//Feito
        {
            if (!CriarPedido())
            {
                return;
            }

            Pedido.InserirPedido(itensSelecionados);
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

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Form_Clientes f = new Form_Clientes();
            f.Show();
            this.Hide();
        }

        private void buttonAdicionarServico_Click(object sender, EventArgs e)
        {
            if (dataGridViewServico.SelectedRows.Count == 0 || dataGridViewServico.SelectedRows[0].Index < 0)
            {
                labelErro.Text = "Selecione um 'Servico'.";
                return;
            }

            var id = (int)dataGridViewServico.SelectedRows[0].Cells[0].Value;

            itensSelecionados.Add(new PedidoItem()
            {
                IdServico = id,
            });

            AtualizarItems();
        }

        private void buttonAdicionarItem_Click(object sender, EventArgs e)//Feito
        {
            if (dataGridViewProduto.SelectedRows.Count == 0 || dataGridViewProduto.SelectedRows[0].Index < 0)
            {
                labelErro.Text = "Selecione um 'Produto'.";
                return;
            }

            if (numericQuantidade.Value <= 0)
            {
                labelErro.Text = "A quantidade do 'Produto' deve ser maior que zero.";
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

        private void buttonRemoverItem_Click(object sender, EventArgs e)
        {
            if (dataGridViewItem.SelectedRows.Count == 0 || dataGridViewItem.SelectedRows[0].Index < 0)
            {
                labelErro.Text = "Selecione um 'Item' lista.";
                return;
            }

            var servicoId = dataGridViewItem.SelectedRows[0].Cells[1]?.Value;
            var produtoId = dataGridViewItem.SelectedRows[0].Cells[2]?.Value;

            if (servicoId != null)
            {
                itensSelecionados.RemoveAt(itensSelecionados.FindIndex(i => i.IdServico == (int) servicoId));
            }

            if (produtoId != null)
            {
                itensSelecionados.RemoveAt(itensSelecionados.FindIndex(i => i.IdProduto == (int) produtoId));
            }

            AtualizarItems();
        }
    }
}
