

using Projeto_Integrador_Dominio.Repositorio;

namespace Projeto_Integrador_Dominio.Dominio
{
    internal class Pedido
    {
        private RepositorioPedido RepositorioPedido = new();

        public int Id { get; set; }
        public Cliente? Cliente { get; set; }
        public Produto Produto { get; set; }
        public int Quantidade { get; set; }
        public Servico Servico { get; set; }
        public DateTime DataDoPedido  { get; set; }
        public Status Status { get; set; }
        public Pagamento Pagamento { get; set; }
        public Decimal Valor { get; set; }


        public string ValidarPedido()
        {
            if (Id < 0)
            {
                return "Não foi possivel gerar o pedido";
            }

            if (Produto == null && Servico == null)
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

        public void InserirItem()
        {
            RepositorioPedido.InserirItem();
        }

        public List<Pedido> ListarPedidosPendentes()
        {
            return RepositorioPedido.ListarPedidosPendentes();
        }

        public void AtualizarPedido()
        {
            RepositorioPedido.AtualizarPedido(this);
        }

        public void DeletarPedido()
        {
            RepositorioPedido.DeletarPedido(this);
        }

    }
}
