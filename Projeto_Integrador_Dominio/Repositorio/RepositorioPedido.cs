using MySql.Data.MySqlClient;
using Projeto_Integrador_Dominio.BancoDados;
using Projeto_Integrador_Dominio.Dominio;


namespace Projeto_Integrador_Dominio.Repositorio
{
    internal class RepositorioPedido
    {
        public Pedido? BuscarIdPedido(Pedido pedido)
        {
            string query = "SELECT c *, id_cliente FROM cliente c INNER JOIN cliente ON pedido.id_cliente = cliente.id WHERE id = @id;";
            using (var conn = DataBase.GetConnection())
            {
                conn.Open();

                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", pedido.Id);
                    cmd.Parameters.AddWithValue("@id_cliente", pedido.Cliente.Nome);
                    cmd.Parameters.AddWithValue("@produto", pedido.Produto);
                    cmd.Parameters.AddWithValue("@quantidade", pedido.Quantidade);
                    cmd.Parameters.AddWithValue("@servico", pedido.Servico);
                    cmd.Parameters.AddWithValue("@dataDoPedido", pedido.DataDoPedido);
                    cmd.Parameters.AddWithValue("@estado", pedido.Status);
                    using var reader = cmd.ExecuteReader();

                    if (!reader.Read())
                    {
                        return null;
                    }

                    return new Pedido
                    {
                        Id = reader.GetInt32("id"),
                        Produto = (Produto)reader.GetInt32("produto"),
                        Quantidade = reader.GetInt32("quantidade"),
                        Servico = (Servico)reader.GetInt32("servico"),
                        DataDoPedido = reader.GetDateTime("dataDoPedido"),
                        Status = (Status)reader.GetInt32("estado"),

                        Cliente = new Cliente()
                        {
                            Id = reader.GetInt32("cliente.id"),
                            Nome = reader.GetString("cliente.nome"),
                            Email = reader.GetString("cliente.email"),
                            Telefone = reader.GetString("cliente.telefone"),
                            CPF = reader.GetString("cliente.cpf")
                        }

                    };
                }
            }

        }

        public void InserirPedido(Pedido NovoPedido)
        {
            using (var con = DataBase.GetConnection())
            {
                con.Open();

                string query = $"INSERT INTO pedido p(c.nome, p.dataDoPedido, p.estado) VALUES(@c.nome, @p.dataDoPedido, {Status.Pendente}) INNER JOIN cliente c ON p.id_cliente c.id;";

                using (var cmd = new MySqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@c.nome", NovoPedido.Cliente.Nome);
                    cmd.Parameters.AddWithValue("@p.dataDoPedido", NovoPedido.DataDoPedido);
                    cmd.Parameters.AddWithValue("@estado", NovoPedido.Status);
                    cmd.ExecuteNonQuery();
                }
            }

        }

        public void InserirItem()
        {

        }

        public void RemoverItem()
        {

        }

        public List<Pedido> ListarItens()
        {
            var item = new List<Pedido>();

            using (var conn = DataBase.GetConnection())
            {
                conn.Open();


            }
            return item;   
        }

        public List<Pedido> ListarPedidosPendentes()
        {
            var pedidos = new List<Pedido>();

            using (var conn = DataBase.GetConnection())
            {
                conn.Open();

                string query = $"SELECT * FROM pedido WHERE estado = {Status.Pendente};";

                using (var cmd = new MySqlCommand(query, conn))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            pedidos.Add(new Pedido
                            {
                                Id = reader.GetInt32("id"),
                                Produto = (Produto)reader.GetByte("produto"),
                                Quantidade = reader.GetInt32("quantidade"),
                                Servico = (Servico)reader.GetByte("servico"),
                                DataDoPedido = reader.GetDateTime("dataDoPedido"),
                                Status = (Status)reader.GetByte("estado"),
                                Cliente = new Cliente()
                                {
                                    Id = reader.GetInt32("cliente.id"),
                                    Nome = reader.GetString("cliente.nome"),
                                    Email = reader.GetString("cliente.email"),
                                    Telefone = reader.GetString("cliente.telefone"),
                                    CPF = reader.GetString("cliente.cpf")
                                },
                            });
                        };
                    }
                }
            }
            return pedidos;
        }

        public void AtualizarPedido(Pedido pedido)
        {
            using (var con = DataBase.GetConnection())
            {
                con.Open();

                string query = "UPDATE pedido ped SET ped.estado = @ped.estado WHERE ped.id = @ped.id;";

                using (var cmd = new MySqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@ped.estado", pedido.Status);
                    cmd.Parameters.AddWithValue("@ped.id", pedido.Id);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void DeletarPedido(Pedido Pedido)
        {
            using (var con = DataBase.GetConnection())
            {
                con.Open();

                string query = $"DELETE FROM pedido p WHERE id = @id";

                using (var cmd = new MySqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("id", Pedido.Id);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}

    
    

