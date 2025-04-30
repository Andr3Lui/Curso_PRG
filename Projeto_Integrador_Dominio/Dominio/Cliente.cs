


using Projeto_Integrador_Dominio.Repositorio;

namespace Projeto_Integrador_Dominio.Dominio
{
    internal class Cliente
    {
        private RepositorioPI RepositorioPI = new();

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string CPF { get; set; }


        

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

            var clienteExistente = RepositorioPI.BuscarEmail(Email);
            if (clienteExistente != null && clienteExistente?.Id != Id)
            {
                return "Email já cadastrado";
            }

            if (string.IsNullOrWhiteSpace(Email))
            {
                return "'Email' não foi preenchido";
            }

            if (!Email.Contains("@") || !Email.EndsWith(".com"))
            {
                return "Insira um 'Email' válido";
            }

            clienteExistente = RepositorioPI.BuscarTelefone(Telefone);
            if(clienteExistente != null && clienteExistente?.Id != Id)
            {
                return "Telefone já cadastrado";
            }

            if (string.IsNullOrWhiteSpace(Telefone))
            {
                return "'Telefone' não foi preenchido";
            }

            if (Telefone.Length != 11)
            {
                return "número de 'Telefone' inválido";
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

        public Cliente? BuscarID(int Id)
        {
            return RepositorioPI.BuscarID(Id);
        }

        public void InserirCliente()
        {
            RepositorioPI.InserirCliente(this);
        }

        public List<Cliente> ListarClientes()
        {
            return RepositorioPI.ListarClientes();
        }

        public void EditarCliente()
        {
             RepositorioPI.EditarCliente(this);
        }

        public void RemoverCliente(int id)
        {
            RepositorioPI.RemoverCliente(id);
        }
    } 


}

    




