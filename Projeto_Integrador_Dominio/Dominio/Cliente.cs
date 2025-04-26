


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

            if (Email.Contains("@") && Email.EndsWith(".com"))
            {
                return "Insira um 'Email' válido";
            }

            if (Telefone.Length != 11)
            {
                return "número de 'Telefone' inválido";
            }

            if (CPF.Length != 11)
            {
                return "CPF invalido";
            }

            return string.Empty;
        }

       /* public string ValidarNome() 
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

            return string.Empty;
        }

        public string ValidarEmail()
        {
            if (string.IsNullOrWhiteSpace(Email))
            {
                return "'Email' não foi preenchido";
            }

            if (Email.Contains("@") && Email.EndsWith(".com"))
            {
                return "Insira um 'Email' válido";
            }

            return string.Empty;
        }

        public string ValidarTelefone()
        {
            if (Telefone.Length != 11)
            {
                return "número de 'Telefone' inválido";
            }

            /*if (Telefone.All(char.IsNumber))
            {
                return "Insira apenas números em telefone";
            }
            return string.Empty;
        }

        public string ValidarCPF()
        {
            if (CPF.Length != 11)
            {
                return "CPF invalido";
            }

            /*if (CPF.All(char.IsNumber))
            {
                return "Insira apenas números em telefone";
            }
            
        }*/

     

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

    




