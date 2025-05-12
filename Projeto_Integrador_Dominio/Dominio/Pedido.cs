

using Projeto_Integrador_Dominio.Repositorio;

namespace Projeto_Integrador_Dominio.Dominio
{
    internal class Pedido
    {
        private RepositorioPedido RepositorioPedido = new();

        public int Id { get; set; }
        public Cliente Cliente { get; set; }
        public DateTime DataDoPedido  { get; set; }
        public Pagamento Pagamento { get; set; }
        public decimal Valor { get; set; }


        public string ValidarPedido()
        {
            if (Cliente == null || Cliente.Id <= 0)
            {
                return "Cliente é obrigatório";
            }

            return string.Empty;
        }


        //PEDIDO
        public void InserirPedido(List<PedidoItem> itensSelecionados)
        {
            RepositorioPedido.InserirPedido(this, itensSelecionados);
        }

        //PRODUTO
        public List<Produto> ListarProduto()//listar todos os servico
        {
            return RepositorioPedido.ListarProduto();
        }  

        public List<Produto> BuscarProduto(string produtoDigitado) //buscar produto digitado no campo 'Produto'
        {
            return RepositorioPedido.BuscarProduto(produtoDigitado);
        }

        //SERVICO
        public List<Servico> ListarServico()//listar todos os servico 
        {
            return RepositorioPedido.ListarServico();
        } 

        public List<Servico> BuscarServico(string servicoDigitado) //buscar servico digitado no campo 'Servico'
        {
            return RepositorioPedido.BuscarServico(servicoDigitado);
        }

    }
}
