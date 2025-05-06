using MySql.Data.MySqlClient;
using Projeto_Integrador_Dominio.BancoDados;
using Projeto_Integrador_Dominio.Dominio;


namespace Projeto_Integrador_Dominio.Repositorio
{
    internal class RepositorioCliente
    {
        public void InserirCliente(Cliente NovoCliente)
        {
            using (var con = DataBase.GetConnection())
            {
                con.Open();

                string query = $"INSERT INTO cliente(nome, email, cpf, telefone) VALUES(@nome, @email, @cpf, @telefone);";

                using (var cmd = new MySqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@nome", NovoCliente.Nome);
                    cmd.Parameters.AddWithValue("@email", NovoCliente.Email);
                    cmd.Parameters.AddWithValue("@telefone", NovoCliente.Telefone);
                    cmd.Parameters.AddWithValue("@cpf", NovoCliente.CPF);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public List<Cliente> ListarClientes()
        {
            var clientes = new List<Cliente>();

            using (var conn = DataBase.GetConnection())
            {
                conn.Open();

                string query = "SELECT * FROM cliente";

                using (var cmd = new MySqlCommand(query, conn))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            clientes.Add(new Cliente
                            {
                                Id = reader.GetInt32("id"),
                                Nome = reader.GetString("nome"),
                                Email = reader.GetString("email"),
                                Telefone = reader.GetString("telefone"),
                                CPF = reader.GetString("cpf")
                            });
                        };
                    }
                }
            }
            return clientes;
        }

        public List<Cliente> BuscarCliente(string clienteDigitado)
        {
            List<Cliente> Cliente = [];

            using (var con = DataBase.GetConnection())
            {
                con.Open();

                string query = $"SELECT * FROM cliente WHERE nome LIKE '%@nomeDigitado%';";

                using (var cmd = new MySqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@nomeDigitado", $"{clienteDigitado}%");
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Cliente.Add(new Cliente 
                            {
                                Id = reader.GetInt32("id"),
                                Nome = reader.GetString("nome"),
                                Email = reader.GetString("email"),
                                Telefone = reader.GetString("telefone"),
                                CPF = reader.GetString("cpf")
                            });
                        }
                    }
                }
            }

            return Cliente;
        }

        public Cliente? BuscarID(int Id)
        {
            string query = "SELECT * FROM cliente WHERE id = @param;";
            return BuscarClienteUnique(query, Id.ToString());
        }

        public Cliente? BuscarEmail(string Email)
        {
            string query = "SELECT * FROM cliente WHERE email = @param;";
            return BuscarClienteUnique(query, Email);
        }

        public Cliente? BuscarCPF(string CPF)
        {
            string query = "SELECT * FROM cliente WHERE cpf = @param;";
            return BuscarClienteUnique(query, CPF);
        }

        public Cliente? BuscarTelefone(string Telefone)
        {
            string query = "SELECT * FROM cliente WHERE telefone = @param;";
            return BuscarClienteUnique(query, Telefone);
        }

        public Cliente? BuscarClienteUnique(string query, string param)
        {
            using (var conn = DataBase.GetConnection())
            {
                conn.Open();

                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@param", param);
                    using var reader = cmd.ExecuteReader();

                    if (!reader.Read())
                    {
                        return null;
                    }

                    return new Cliente
                    {
                        Id = reader.GetInt32("id"),
                        Nome = reader.GetString("nome"),
                        Email = reader.GetString("email"),
                        Telefone = reader.GetString("telefone"),
                        CPF = reader.GetString("cpf")
                    };
                }
            }
        }

        public void EditarCliente(Cliente EditarCliente)
        {
            using (var con = DataBase.GetConnection())
            {
                con.Open();

                string query = "UPDATE cliente SET nome = @nome, email = @email, telefone = @telefone, cpf = @cpf  WHERE id = @id;";

                using (var cmd = new MySqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@id", EditarCliente.Id);
                    cmd.Parameters.AddWithValue("@nome", EditarCliente.Nome);
                    cmd.Parameters.AddWithValue("@email", EditarCliente.Email);
                    cmd.Parameters.AddWithValue("@telefone", EditarCliente.Telefone);
                    cmd.Parameters.AddWithValue("@cpf", EditarCliente.CPF);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void RemoverCliente(int id)
        {
            using (var con = DataBase.GetConnection())
            {
                con.Open();

                string query = "DELETE FROM cliente WHERE id = @id;";

                using (var cmd = new MySqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }

            }
        }
    }
}
