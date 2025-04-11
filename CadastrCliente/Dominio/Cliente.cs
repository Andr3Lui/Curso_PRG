using CadastrCliente.Repositorio;

namespace CadastrCliente.Dominio
{
    internal class Cliente
    {
        private readonly Cliente_Repositorio clienteRepositorio = new();

        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public EnderecoCliente Endereco { get; set; }
        public GeneroCliente Genero { get; set; }
        public bool Estrangeiro { get; set; }
        public EtniaCliente Etnia { get; set; }
        public string NomeSocial { get; set; }
        public TipoCliente Tipo { get; set; }

        public List<Cliente> ListarClientes()
        {
            return clienteRepositorio.ListarClientes();
        }

        public void InserirCliente(Cliente novoCliente)
        {
            clienteRepositorio.InserirCliente(novoCliente);
        }

    }
}
