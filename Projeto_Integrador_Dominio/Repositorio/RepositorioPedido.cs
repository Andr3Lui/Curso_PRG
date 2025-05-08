using MySql.Data.MySqlClient;
using Projeto_Integrador_Dominio.BancoDados;
using Projeto_Integrador_Dominio.Dominio;
using System.Drawing;


namespace Projeto_Integrador_Dominio.Repositorio
{
    internal class RepositorioPedido
    {

        //PEDIDO
        public Pedido? BuscarIdPedido(Pedido pedido)
        {
            string query = "SELECT c *, id_cliente FROM cliente c INNER JOIN cliente ON pedido.id_cliente = cliente.id WHERE id = @id;";
            using (var conn = DataBase.GetConnection())
            {
                conn.Open();

                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", pedido.Id);
                    cmd.Parameters.AddWithValue("@id_cliente", pedido.Cliente?.Nome);
                    cmd.Parameters.AddWithValue("@produto", pedido.Produto);
                    cmd.Parameters.AddWithValue("@quantidade", pedido.Quantidade);
                    cmd.Parameters.AddWithValue("@servico", pedido.Servico);
                    cmd.Parameters.AddWithValue("@dataDoPedido", pedido.DataDoPedido);
                    cmd.Parameters.AddWithValue("@estado", pedido.Estado);
                    using var reader = cmd.ExecuteReader();

                    if (!reader.Read())
                    {
                        return null;
                    }

                    return new Pedido
                    {
                        Id = reader.GetInt32("id"),
                        Quantidade = reader.GetInt32("quantidade"),
                        DataDoPedido = reader.GetDateTime("dataDoPedido"),
                        Estado = (Estado)reader.GetInt32("estado"),

                        Produto = new Produto() 
                        {
                            Id = reader.GetInt32("id"),
                            Nome = reader.GetString("nome"),
                            Valor = reader.GetDecimal("valor"),
                            Estoque = reader.GetInt32("estoque")
                        },

                        Servico = new Servico() 
                        {
                            Id = reader.GetInt32("id"),
                            Nome = reader.GetString("nome"),
                            Valor = reader.GetDecimal("valor"),
                        },

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

        public List<Pedido> ListarPedidoPendentes()
        {
            var pedidos = new List<Pedido>();

            using (var conn = DataBase.GetConnection())
            {
                conn.Open();

                string query = $"SELECT * FROM pedido INNER JOIN cliente ON pedido.id_cliente = cliente.id WHERE estado = @estado;";

                using (var cmd = new MySqlCommand(query, conn))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            pedidos.Add(new Pedido
                            {
                                Id = reader.GetInt32("id"),
                                Quantidade = reader.GetInt32("quantidade"),
                                DataDoPedido = reader.GetDateTime("dataDoPedido"),
                                Estado = (Estado)reader.GetByte("estado"),

                                Produto = new Produto()
                                {
                                    Id = reader.GetInt32("id"),
                                    Nome = reader.GetString("nome"),
                                    Valor = reader.GetDecimal("valor"),
                                    Estoque = reader.GetInt32("estoque")
                                },

                                Servico = new Servico()
                                {
                                    Id = reader.GetInt32("id"),
                                    Nome = reader.GetString("nome"),
                                    Valor = reader.GetDecimal("valor"),
                                },

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
                    cmd.Parameters.AddWithValue("@ped.estado", pedido.Estado);
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

        //PRODUTO

        public List<Produto> ListarProduto()
        {
            var produto = new List<Produto>();

            using (var conn = DataBase.GetConnection())
            {
                conn.Open();

                string query = "SELECT * FROM produto";

                using (var cmd = new MySqlCommand(query, conn))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            produto.Add(new Produto
                            {
                                Id = reader.GetInt32("id"),
                                Nome = reader.GetString("nome"),
                                Valor = reader.GetDecimal("valor"),
                                Estoque = reader.GetInt32("estoque")
                            });
                        }
                    }
                }
            }
            return produto;
        }

        public List<Produto> BuscarProduto(string produtoDigitado)
        {
            List<Produto> buscarProduto = [];

            using (var conn = DataBase.GetConnection())
            {
                conn.Open();

                string query = "SELECT * FROM produto WHERE nome LIKE @produtoDigitado;";

                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@produtoDigitado", $"{produtoDigitado}%");
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            buscarProduto.Add(new Produto()
                            {
                                Id = reader.GetInt32("id"),
                                Nome = reader.GetString("nome"),
                                Valor = reader.GetDecimal("valor"),
                                Estoque = reader.GetInt32("estoque")
                            });
                        }
                    }
                }
            }
            return buscarProduto;
        }

        public void InserirProduto(int produto, int pedido)
        {
            using (var con = DataBase.GetConnection())
            {
                con.Open();
                string queryProduto = "INSERT INTO PedidoProduto(id_produto, id_pedido) VALUES(@id_produto, @id_pedido) ;";
                using (var cmd = new MySqlCommand(queryProduto, con))
                {
                    cmd.Parameters.AddWithValue("@id_produto", produto);
                    cmd.Parameters.AddWithValue("@id_pedido", pedido);
                    cmd.ExecuteNonQuery();
                }
                
            }
            
        }

        //SERVICO
        public List<Servico> ListarServico()
        {
            var servico = new List<Servico>();

            using (var conn = DataBase.GetConnection())
            {
                conn.Open();

                string query = "SELECT * FROM servico";

                using (var cmd = new MySqlCommand(query, conn))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            servico.Add(new Servico
                            {
                                Id = reader.GetInt32("id"),
                                Nome = reader.GetString("nome"),
                                Valor = reader.GetDecimal("valor")
                            });
                        }
                    }
                }
            }
            return servico;
        }

        public List<Servico> BuscarServico(string servicoDigitado)
        {
            List<Servico> buscarServico = [];

            using (var conn = DataBase.GetConnection())
            {
                conn.Open();

                string query = "SELECT * FROM servico WHERE nome LIKE @produtoDigitado;";

                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@produtoDigitado", $"{servicoDigitado}%");
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            buscarServico.Add(new Servico()
                            {
                                Id = reader.GetInt32("id"),
                                Nome = reader.GetString("nome"),
                                Valor = reader.GetDecimal("valor")
                            });
                        }
                    }
                }
            }
            return buscarServico;
        }

        public void InserirServico(Pedido servico)
        {
            using (var con = DataBase.GetConnection())
            {
                con.Open();
                string queryProduto = "INSERT INTO PedidoProduto(id_produto, id_pedido) VALUES(@id_produto, @id_pedido);";
                using (var cmd = new MySqlCommand(queryProduto, con))
                {
                    cmd.Parameters.AddWithValue("@id_produto", servico.Produto);
                    cmd.Parameters.AddWithValue("@id_pedido", servico.Id);
                    cmd.ExecuteNonQuery();
                }

            }

        }

        //ITENS
        public List<Pedido> ListarItem()
        {
            var pedidos = new List<Pedido>();

            using (var conn = DataBase.GetConnection())
            {
                conn.Open();

                string query = $"SELECT id_cliente AS cliente, servico, produto, quantidade, dataDoPedido FROM pedido INNER JOIN cliente ON pedido.id_cliente = cliente.id;";

                using (var cmd = new MySqlCommand(query, conn))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            pedidos.Add(new Pedido
                            {
                                Id = reader.GetInt32("id"),
                                Quantidade = reader.GetInt32("quantidade"),
                                DataDoPedido = reader.GetDateTime("dataDoPedido"),
                                Estado = (Estado)reader.GetByte("estado"),
                                Pagamento = (Pagamento)reader.GetByte("pagamento"),
                                Valor = reader.GetDecimal("valor"),

                                Produto = new Produto()
                                {
                                    Id = reader.GetInt32("produto.id"),
                                    Nome = reader.GetString("produto.nome"),
                                    Valor = reader.GetDecimal("produto.valor"),
                                    Estoque = reader.GetInt32("produto.estoque")
                                },

                                Servico = new Servico()
                                {
                                    Id = reader.GetInt32("servico.id"),
                                    Nome = reader.GetString("servico.nome"),
                                    Valor = reader.GetDecimal("servico.valor"),
                                },

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

        public void RemoverItem(int Id)
        {
            using (var con = DataBase.GetConnection())
            {
                con.Open();

                string queryProduto = "DELETE FROM PedidoProduto WHERE id = @id";
                string queryServico = "DELETE FROM PedidoServico WHERE id = @id";

                using (var cmd = new MySqlCommand(queryProduto, con))
                {
                    cmd.Parameters.AddWithValue("@id", Id);
                    cmd.ExecuteNonQuery();
                }

                using (var cmd = new MySqlCommand(queryServico, con))
                {
                    cmd.Parameters.AddWithValue("@id", Id);
                    cmd.ExecuteNonQuery();
                }
            }
        }


    }
}

    
    

