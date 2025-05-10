using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Integrador_Dominio.Dominio
{
    internal class PedidoItem
    {
        public int IdPedido { get; set; }
        public int? IdServico { get; set; }
        public int? IdProduto { get; set; }
        public int? Quantidade { get; set; }
    }
}
