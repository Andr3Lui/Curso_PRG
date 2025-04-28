using MySql.Data.MySqlClient;
using Projeto_Integrador_Dominio.BancoDados;
using Projeto_Integrador_Dominio.Dominio;


namespace Projeto_Integrador_Dominio.Repositorio
{
    internal class RepositorioPI
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
                    cmd.Parameters.AddWithValue("@cpf", NovoCliente.CPF);
                    cmd.Parameters.AddWithValue("@telefone", NovoCliente.Telefone); 
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void InserirPedido(Pedido NovoPedido)
        {
            using (var con = DataBase.GetConnection())
            {
                con.Open();

                string query = $"INSERT INTO pedido p(c.nome, p.dataDoPedido, p.estado) VALUES(@c.nome, @p.dataDoPedido, {Estado.Pendente}) INNER JOIN cliente c ON p.id_cliente c.id;";

                using (var cmd = new MySqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@c.nome", NovoPedido.Cliente.Nome);
                    cmd.Parameters.AddWithValue("@p.dataDoPedido", NovoPedido.DataDoPedido);
                    cmd.Parameters.AddWithValue("@estado", NovoPedido.Estado);
                    cmd.ExecuteNonQuery();
                }
            }

        }

        //public List<Pedido> BuscarPedidosPendentes()
        //{
        //    var pedidos = new List<Pedido>();

        //    using (var conn = DataBase.GetConnection())
        //    {
        //        conn.Open();

        //        string query = "SELECT * FROM pedido WHERE estado = {Estado.Pendente};";

        //        using (var cmd = new MySqlCommand(query, conn))
        //        {
        //            using (var reader = cmd.ExecuteReader())
        //            {
        //                while (reader.Read())
        //                {
        //                    pedidos.Add(new Pedido
        //                    {
        //                        Id = reader.GetInt32("id"),
        //                        Cliente = (Cliente.Id)reader.("cliente"),
        //                        Produto = (Produto)reader.GetByte("produto"),
        //                        Quantidade = reader.GetString("quantidade"),
        //                        Servico = (Servico)reader.GetByte("servico"),
        //                        DataDoPedido = reader.GetDateTime("dataDoPedido"),
        //                        Estado = (Estado)reader.GetByte("estado")
        //                    });
        //                };
        //            }
        //        }
        //    }
        //    return pedidos;
        //}

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

        public void AtualizarPedido(int id, bool novoEstado)
        {
            using (var con = DataBase.GetConnection())
            {
                con.Open();

                string query = "UPDATE pedido ped SET ped.estado = @ped.estado WHERE ped.id = @ped.id;";

                using (var cmd = new MySqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@ped.estado", novoEstado);
                    cmd.Parameters.AddWithValue("@ped.id", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void CancelarPedido(Pedido NovoPedido)
        {
            using (var con = DataBase.GetConnection())
            {
                con.Open();

                string query = $"DELETE FROM pedido p WHERE p.estado = {Estado.Pendente}";

                using (var cmd = new MySqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("id", NovoPedido.Id);
                    cmd.Parameters.AddWithValue("estado", NovoPedido.Estado);
                    cmd.ExecuteNonQuery();
                }
            }
        }



    }
}
