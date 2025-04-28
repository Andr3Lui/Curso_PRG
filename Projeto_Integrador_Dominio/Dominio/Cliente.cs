


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


        public bool ValidarIdCliente()
        {
            return Id > 0;
        }

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

            if (string.IsNullOrWhiteSpace(Email))
            {
                return "'Email' não foi preenchido";
            }

            //if (Email.Contains("@"))
            //{
            //    return "Insira um 'Email' válido";
            //}

            if (Telefone.Length != 11)
            {
                return "número de 'Telefone' inválido";
            }

            if (CPF.Length < 11)
            {
                return "CPF invalido";
            }

            return string.Empty;
        }

        public void InserirCliente()
        {
            RepositorioPI.InserirCliente(this);
        }

        public List<Cliente> ListarClientes()
        {
            return RepositorioPI.ListarClientes();
        }
    } 


}

    




