using CadastrCliente.Banco_Dados;
using CadastrCliente.Dominio;
using MySql.Data.MySqlClient;


namespace CadastrCliente.Repositorio
{
    internal class Cliente_Repositorio
    {
        public List<Cliente> ListarClientes()
        {
            var clientes = new List<Cliente>();

            using (var conn = DataBase.GetConnection())
            {
                conn.Open();

                string query = "SELECT c.*, e.logradouro, e.numero, e.complemento, e.bairro, e.municipio, e.estado, e.cep FROM cliente c JOIN endereco e ON c.id_endereco = e.id;";

                using var cmd = new MySqlCommand(query, conn);
                using var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    var nomeSocial = !reader.IsDBNull("nome_social") ? reader.GetString("nome_social") : "";
                    var complemento = !reader.IsDBNull("complemento") ? reader.GetString("complemento") : "";


                    clientes.Add(new Cliente
                    {
                        Id = reader.GetInt32("id"),
                        Nome = reader.GetString("nome"),
                        NomeSocial = nomeSocial,
                        DataNascimento = reader.GetDateTime("data_nascimento"),
                        Email = reader.GetString("email"),
                        Telefone = reader.GetString("telefone"),
                        Tipo = (TipoCliente)reader.GetInt32("tipo"),
                        Etnia = (EtniaCliente)reader.GetInt32("etnia"),
                        Genero = (GeneroCliente)reader.GetInt32("genero"),
                        Estrangeiro = reader.GetBoolean("estrangeiro"),
                        Endereco = new EnderecoCliente
                        {
                            Id = reader.GetInt32("id_endereco"),
                            Logradouro = reader.GetString("logradouro"),
                            Numero = reader.GetString("numero"),
                            Complemento = complemento,
                            Bairro = reader.GetString("bairro"),
                            Municipio = reader.GetString("municipio"),
                            Estado = reader.GetString("estado"),
                            CEP = reader.GetString("cep")
                        }
                    });
                }
            }

            return clientes;
        }

    }
}
