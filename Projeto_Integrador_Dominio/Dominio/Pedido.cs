

using Projeto_Integrador_Dominio.Repositorio;

namespace Projeto_Integrador_Dominio.Dominio
{
    internal class Pedido
    {
        private RepositorioPI Repositorio = new();

        public int Id { get; set; }
        public Cliente Cliente { get; set; }
        public Produto Produto { get; set; }
        public string Quantidade { get; set; }
        public Servico Servico { get; set; }
        public DateTime DataDoPedido  { get; set; }
        public Estado Estado { get; set; }

        public bool ValidarId()
        {
            return Id > 0;
        }

        public bool ValidarEstado()
        {
            return Estado != Estado.Realizado;
        } 
        
        public void ListarClientes()
        {
            Repositorio.ListarClientes();   
        }

        public void InserirPedido()
        {
            Repositorio.InserirPedido(this);
        }
    }
}
