

using Projeto_Integrador_Dominio.Repositorio;

namespace Projeto_Integrador_Dominio.Dominio
{
    internal class Pedido
    {
        private RepositorioPedido RepositorioPedido = new();

        public int Id { get; set; }
        public Cliente Cliente { get; set; }
        public DateTime DataDoPedido  { get; set; }
        public Estado Estado { get; set; }
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

        //public Pedido? BuscarIdPedido()
        //{
        //    return RepositorioPedido.BuscarIdPedido(this);
        //}

        public void InserirPedido(List<PedidoItem> itensSelecionados)
        {
            RepositorioPedido.InserirPedido(this, itensSelecionados);
        }

        public List<Pedido> ListarPedidoPendentes()
        {
            return RepositorioPedido.ListarPedidoPendentes();
        }

        public void AtualizarPedido()
        {
            RepositorioPedido.AtualizarPedido(this);
        }

        public void DeletarPedido()
        {
            RepositorioPedido.DeletarPedido(this);
        }

        /*
        public Produto InserirProduto()
        {
            RepositorioPedido.InserirProduto();
        }

        public void

        public Servico InserirServico()
        {
            RepositorioPedido.InserirServico(this);
        }
        */

        //PRODUTO


        public List<Produto> ListarProduto()//listar todos os servico
        {
            return RepositorioPedido.ListarProduto();
        }  

        public List<Produto> BuscarProduto(string produtoDigitado) //buscar produto digitado no campo 'Produto'
        {
            return RepositorioPedido.BuscarProduto(produtoDigitado);
        }

        public void InserirProduto(int idPedido,int idProduto)
        {
            RepositorioPedido.InserirProduto(idPedido, idProduto);
        }

        //SERVICO
        public void InserirServico(int pedido, int servico)
        {
            RepositorioPedido.InserirProduto(pedido, servico);
        }

        public List<Servico> ListarServico()//listar todos os servico 
        {
            return RepositorioPedido.ListarServico();
        } 

        public List<Servico> BuscarServico(string servicoDigitado) //buscar servico digitado no campo 'Servico'
        {
            return RepositorioPedido.BuscarServico(servicoDigitado);
        }

        //ITENS
        public List<Pedido> ListarItens()
        {
             return RepositorioPedido.ListarItens();
        }

        public void RemoverItem(int Id)
        {
            RepositorioPedido.RemoverItem(Id);
        }
    }
}
