using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastrCliente
{
    internal class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string DataNascimento { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public EnderecoCliente Endereco { get; set; }
        public GeneroCliente Genero { get; set; }
        public bool Estrangeiro { get; set; }
        public EtniaCliente Etnia { get; set; }
        public string NomeSocial  { get; set; }
        public TipoCliente Tipo { get; set; }
    }
}
