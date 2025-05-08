

using Projeto_Integrador_Dominio.Repositorio;

namespace Projeto_Integrador_Dominio.Dominio
{
    internal class Pedido
    {
        private RepositorioPedido RepositorioPedido = new();

        public int Id { get; set; }
        public Cliente? Cliente { get; set; }
        public Produto? Produto { get; set; }
        public int Quantidade { get; set; }
        public Servico? Servico { get; set; }
        public DateTime DataDoPedido  { get; set; }
        public Estado Estado { get; set; }
        public Pagamento Pagamento { get; set; }
        public decimal Valor { get; set; }


        public string ValidarPedido()
        {

            if (Cliente?.Nome == null)
            {
                return "Selecione um 'Cliente'";
            }

            //if (string.IsNullOrWhiteSpace(Cliente.Nome) || !Cliente.Nome.Contains(' ') )
            //{
            //    return "Selecione um 'Cliente'";
            //}

            //if (Cliente.Nome.Contains('@') || Cliente.Nome.Any(char.IsNumber) || Cliente.Nome.Any(char.IsPunctuation) || Cliente.Nome.Any(char.IsSymbol))
            //{
            //    return "Preencha 'Cliente' apenas com letras";
            //}

            if (string.IsNullOrWhiteSpace(Produto?.Nome) && string.IsNullOrWhiteSpace(Servico?.Nome))
            {
                return "Escolha um 'Serviço' ou 'Produto'";
            }

            

            return string.Empty;
        }

        public Pedido? BuscarIdPedido()
        {
            return RepositorioPedido.BuscarIdPedido(this);
        }

        public void InserirPedido()
        {
            RepositorioPedido.InserirPedido(this);
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
        
        //SERVICO
        public List<Servico> ListarServico()//listar todos os servico 
        {
            return RepositorioPedido.ListarServico();
        } 

        public List<Servico> BuscarServico(string servicoDigitado) //buscar servico digitado no campo 'Servico'
        {
            return RepositorioPedido.BuscarServico(servicoDigitado);
        }

        //ITENS
        public List<Pedido> ListarItem()
        {
             return RepositorioPedido.ListarItem();
        }

        public void RemoverItem(int Id)
        {
            RepositorioPedido.RemoverItem(Id);
        }
    }
}
