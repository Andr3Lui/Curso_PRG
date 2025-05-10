using MySql.Data.MySqlClient;
using Projeto_Integrador_Dominio.BancoDados;
using Projeto_Integrador_Dominio.Dominio;


namespace Projeto_Integrador_Dominio.Repositorio
{
    internal class RepositorioPedido
    {

        //PEDIDO
        //public Pedido? BuscarIdPedido(Pedido pedido)
        //{
        //    string query = "SELECT c *, id_cliente FROM cliente c INNER JOIN cliente ON pedido.id_cliente = cliente.id WHERE id = @id;";
        //    using (var conn = DataBase.GetConnection())
        //    {
        //        conn.Open();

        //        using (var cmd = new MySqlCommand(query, conn))
        //        {
        //            cmd.Parameters.AddWithValue("@id", pedido.Id);
        //            cmd.Parameters.AddWithValue("@id_cliente", pedido.Cliente?.Nome);
        //            cmd.Parameters.AddWithValue("@produto", pedido.Produto);
        //            cmd.Parameters.AddWithValue("@quantidade", pedido.Quantidade);
        //            cmd.Parameters.AddWithValue("@servico", pedido.Servico);
        //            cmd.Parameters.AddWithValue("@dataDoPedido", pedido.DataDoPedido);
        //            cmd.Parameters.AddWithValue("@estado", pedido.Estado);
        //            using var reader = cmd.ExecuteReader();

        //            if (!reader.Read())
        //            {
        //                return null;
        //            }

        //            return new Pedido
        //            {
        //                Id = reader.GetInt32("id"),
        //                Quantidade = reader.GetInt32("quantidade"),
        //                DataDoPedido = reader.GetDateTime("dataDoPedido"),
        //                Estado = (Estado)reader.GetInt32("estado"),

        //                Produto = new Produto() 
        //                {
        //                    Id = reader.GetInt32("id"),
        //                    Nome = reader.GetString("nome"),
        //                    Valor = reader.GetDecimal("valor"),
        //                    Estoque = reader.GetInt32("estoque")
        //                },

        //                Servico = new Servico() 
        //                {
        //                    Id = reader.GetInt32("id"),
        //                    Nome = reader.GetString("nome"),
        //                    Valor = reader.GetDecimal("valor"),
        //                },

        //                Cliente = new Cliente()
        //                {
        //                    Id = reader.GetInt32("cliente.id"),
        //                    Nome = reader.GetString("cliente.nome"),
        //                    Email = reader.GetString("cliente.email"),
        //                    Telefone = reader.GetString("cliente.telefone"),
        //                    CPF = reader.GetString("cliente.cpf")
        //                }

        //            };
        //        }
        //    }

        //}

        public void InserirPedido(Pedido pedido, List<PedidoItem> itensSelecionados)
        {
            int id = 0;

            using var con = DataBase.GetConnection();
            con.Open();

            // Criar um pedido
            var insertPedido = "INSERT INTO pedido (dataDoPedido, valor, estado, id_cliente) VALUES (@dataDoPedido, @valor, @estado, @id_cliente);";
            using (var cmd = new MySqlCommand(insertPedido, con))
            {
                cmd.Parameters.AddWithValue("@dataDoPedido", pedido.DataDoPedido);
                cmd.Parameters.AddWithValue("@valor", pedido.Valor);
                cmd.Parameters.AddWithValue("@estado", pedido.Estado);
                cmd.Parameters.AddWithValue("@id_cliente", pedido.Cliente.Id);
                cmd.ExecuteNonQuery();
            }

            // Buscar o Id desse pedido
            var buscarPedidoCriado = "SELECT id FROM pedido WHERE dataDoPedido = @dataDoPedido AND valor = @valor AND estado = @estado AND id_cliente = @id_cliente;";
            using (var cmd = new MySqlCommand(buscarPedidoCriado, con))
            {
                cmd.Parameters.AddWithValue("@dataDoPedido", $"{pedido.DataDoPedido.Year}-{pedido.DataDoPedido.Month}-{pedido.DataDoPedido.Day} {pedido.DataDoPedido.Hour}:{pedido.DataDoPedido.Minute}:{pedido.DataDoPedido.Second}");
                cmd.Parameters.AddWithValue("@valor", pedido.Valor);
                cmd.Parameters.AddWithValue("@estado", (int) pedido.Estado);
                cmd.Parameters.AddWithValue("@id_cliente", pedido.Cliente.Id);
                using var reader = cmd.ExecuteReader();

                id = reader.Read() ? reader.GetInt32("id") : 0;
            }

            // Criar produtos do pedido
            var insertProduto = "INSERT INTO PedidoProduto (id_produto, id_pedido, quantidade) VALUES (@id_produto, @id_pedido, @quantidade);";
            itensSelecionados.FindAll(item => item.IdProduto != null).ForEach(item =>
            {
                using var cmd = new MySqlCommand(insertProduto, con);
                cmd.Parameters.AddWithValue("@id_produto", item.IdProduto);
                cmd.Parameters.AddWithValue("@id_pedido", id);
                cmd.Parameters.AddWithValue("@quantidade", item.Quantidade);
                cmd.ExecuteNonQuery();
            });

            // Criar servicos do pedido
            var insertServico = "INSERT INTO PedidoServico (id_servico, id_pedido) VALUES (@id_servico, @id_pedido);";
            itensSelecionados.FindAll(item => item.IdServico != null).ForEach(item =>
            {
                using var cmd = new MySqlCommand(insertServico, con);
                cmd.Parameters.AddWithValue("@id_servico", item.IdServico);
                cmd.Parameters.AddWithValue("@id_pedido", id);
                cmd.ExecuteNonQuery();
            });
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
                    cmd.Parameters.AddWithValue("@estado", Estado.Pendente);

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            pedidos.Add(new Pedido
                            {
                                Id = reader.GetInt32("id"),
                                DataDoPedido = reader.GetDateTime("dataDoPedido"),
                                Estado = (Estado)reader.GetByte("estado"),

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

        public void InserirProduto(int pedido, int produto)
        {
            using (var con = DataBase.GetConnection())
            {
                con.Open();
                string query = "INSERT INTO PedidoProduto(id_produto, id_pedido) VALUES(@id_produto, @id_pedido) ;";
                using (var cmd = new MySqlCommand(query, con))
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

        public void InserirServico(int pedido, int servico)
        {
            using (var con = DataBase.GetConnection())
            {
                con.Open();
                string queryProduto = "INSERT INTO PedidoProduto(id_produto, id_pedido) VALUES(@id_produto, @id_pedido);";
                using (var cmd = new MySqlCommand(queryProduto, con))
                {
                    cmd.Parameters.AddWithValue("@id_produto", servico);
                    cmd.Parameters.AddWithValue("@id_pedido", pedido);
                    cmd.ExecuteNonQuery();
                }

            }

        }

        //ITENS
        public List<Pedido> ListarItens()
        {
            var pedido = new List<Pedido>();

            using (var conn = DataBase.GetConnection())
            {
                conn.Open();

                string query = $"SELECT produto.nome, produto.valor FROM pedidoproduto INNER JOIN pedido ON pedido.id = pedidoproduto.id_produto INNER JOIN produto ON produto.id = pedidoproduto.id_produto INNER JOIN servico ON servico.id = pedidoservico.id_servico INNER JOIN cliente ON cliente.id = pedido.id_cliente  WHERE pedido.id = @pedido;";

                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@pedido", $"{pedido}%");
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            pedido.Add(new Pedido
                            {
                                Id = reader.GetInt32("id"),
                                DataDoPedido = reader.GetDateTime("dataDoPedido"),
                                Estado = (Estado)reader.GetByte("estado"),
                                Pagamento = (Pagamento)reader.GetByte("pagamento"),
                                Valor = reader.GetDecimal("valor"),
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
            return pedido;
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




