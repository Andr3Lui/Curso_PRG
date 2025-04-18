using Atividade_Produto.BancoDados;
using MySql.Data.MySqlClient;


namespace Atividade_Produto.Repositorio
{
    internal class RepositorioProduto
    {
        public void AdicionarProduto(Produto novoProduto)
        {
            using (var con = DataBase.GetConnection())
            {
                con.Open();

                string query = $"INSERT INTO produto(nome) VALUES(@nome, @dataEntrada);";

                using (var cmd = new MySqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@produto", novoProduto.Nome);
                    cmd.Parameters.AddWithValue("@produto", novoProduto.DataEntrada);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void DeletarProduto(Produto.Id novoProduto)
        {
            using (var con = DataBase.GetConnection())
            {
                con.Open();

                string query = $"DELETE FROM PRODUTO WHERE id = @id;";

                using (var cmd = new MySqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@id", novoProduto.Id);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void ComprarProduto(Estoque.Id id, Estoque.Nome nome)
        {
            using (var con = DataBase.GetConnection())
            {
                con.Open();

                string query = $"UPDATE produto SET nome = @nome WHERE Id = @Id;"

                using (var cmd = new MySqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@nome", nome.Nome);
                    cmd.Parameters.AddWithValue("@id", id.Id);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void VenderProduto(Estoque produto)
        {
            using (var con = DataBase.GetConnection())
            {
                con.Open();

                string query = $"DELETE FROM PRODUTO WHERE id = @id;";

                using (var cmd = new MySqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@id", produto.Id);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public Produto BuscarProduto()
        {
            using (var con = DataBase.GetConnection())
            {
                con.Open();

                string query = $"SELECT produto.nome, estoque.id, dataEntrada.produto FROM estoque INNER JOIN produto ON estoque.id_produto = produto.id WHERE id_produto = @produto;";

                using (var cmd = new MySqlCommand(query, con))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Produto()
                            {
                                Id = reader.GetInt32("id"),
                                Nome = reader.GetString("nome"),
                               
                            };
                        }
                    }
                }
            }
        }
    }

}
