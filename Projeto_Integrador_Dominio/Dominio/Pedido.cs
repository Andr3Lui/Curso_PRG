

using System.Security.Cryptography.X509Certificates;

namespace Projeto_Integrador_Dominio.Dominio
{
    internal class Pedido
    {
        public int Id { get; set; }
        public Cliente Cliente { get; set; }
        public string Produto { get; set; }
        public string Servico { get; set; }
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
        
        
    }
}
