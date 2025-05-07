


using MySqlX.XDevAPI;
using Projeto_Integrador_Dominio.Repositorio;
using System.Web;

namespace Projeto_Integrador_Dominio.Dominio
{
    internal class Cliente
    {
        private RepositorioCliente RepositorioCliente = new();

        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Email { get; set; }
        public string? Telefone { get; set; }
        public string? CPF { get; set; }


        

        public string ValidarCliente()
        {
            if (string.IsNullOrWhiteSpace(Nome))
            {
                return "'Nome' não foi preenchido";
            }

            if (!Nome.Contains(' '))
            {
                return "Inclua 'Nome' e 'Sobrenome'";
            }

            if (Nome.Contains('@') || Nome.Any(char.IsNumber) || Nome.Any(char.IsPunctuation) || Nome.Any(char.IsSymbol))
            {
                return "Preencha 'Nome' apenas com letras";
            }

            var clienteExistente = RepositorioCliente.BuscarEmail(Email);
            if (clienteExistente != null && clienteExistente?.Id != Id)
            {
                return "'Email' já cadastrado";
            }

            if (string.IsNullOrWhiteSpace(Email))
            {
                return "'Email' não foi preenchido";
            }

            if (!Email.Contains("@") || !Email.EndsWith(".com"))
            {
                return "Insira um 'Email' válido";
            }

            clienteExistente = RepositorioCliente.BuscarTelefone(Telefone);
            if(clienteExistente != null && clienteExistente?.Id != Id)
            {
                return "'Telefone' já cadastrado";
            }

            if (string.IsNullOrWhiteSpace(Telefone))
            {
                return "'Telefone' não foi preenchido";
            }

            if (Telefone.Length != 11)
            {
                return "número de 'Telefone' inválido";
            }

            clienteExistente = RepositorioCliente.BuscarCPF(CPF);
            if (clienteExistente != null && clienteExistente?.Id != Id)
            {
                return "'CPF' já cadastrado";
            }

            if (string.IsNullOrWhiteSpace(CPF))
            {
                return "'CPF' não foi preenchido";
            }

            if (CPF.Length != 11)
            {
                return "CPF invalido";
            }

            return string.Empty;
        }

        public Cliente? BuscarID(int id)
        {
            return RepositorioCliente.BuscarID(id);
        }

        public void InserirCliente()
        {
            RepositorioCliente.InserirCliente(this);
        }

        public List<Cliente> BuscarCliente(string clienteDigitado)
        {
            return RepositorioCliente.BuscarCliente(clienteDigitado);
        }

        public List<Cliente> ListarClientes()
        {
            return RepositorioCliente.ListarClientes();
        }        

        public void EditarCliente()
        {
            RepositorioCliente.EditarCliente(this);
        }

        public void RemoverCliente(int id)
        {
            RepositorioCliente.RemoverCliente(id);
        }
    } 


}

    




