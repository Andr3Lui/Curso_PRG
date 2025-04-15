using ListaAtividades.Banco_Dados;
using ListaAtividades.Dominio;
using MySql.Data.MySqlClient;


namespace ListaAtividades.AtividadeRepositorio
{
    internal class AtividadeRepositorio
    {
        public void CriarAtividade(string titulo) 
        {
            using (var con = DataBase.GetConnection()) 
            {
                con.Open();

                string query = $"INSERT INTO atividade(titulo) VALUES(@titulo);";

                using (var cmd = new MySqlCommand(query, con)) 
                {
                    cmd.Parameters.AddWithValue("@titulo", query);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void AtualizarSituacao(int id, int novaSituacao) 
        {
            using (var con = DataBase.GetConnection())
            {
                con.Open();

                string queryAtualizar = $"UPDATE atividade SET situacao = @situacao WHERE id = @id;";

                using (var cmd = new MySqlCommand(queryAtualizar, con))
                {
                    cmd.Parameters.AddWithValue("@situacao", novaSituacao);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteReader();
                }
            }

        }

        public Atividade BuscarAtividadeEmAndamento() 
        {
            using (var con = DataBase.GetConnection()) 
            {
                con.Open();

                string query = $"SELECT * FROM atividade WHERE situacao = {Situacao.Realizando};";

                using (var cmd = new MySqlCommand(query, con)) 
                {
                    using (var reader = cmd.ExecuteReader()) 
                    {
                        if (reader.Read())
                        {
                            return new Atividade()
                            {
                                Id = reader.GetInt32("id"),
                                titulo = reader.GetString("titulo"),
                                Situacao = (Situacao)reader.GetInt32("situacao")
                            };
                        }   
                    }
                }
            }

                return new Atividade();
        }

        public List<Atividade> ListarAtividadesPendente()
        {
            List<Atividade> atividades = [];

            using (var con = DataBase.GetConnection())
            {
                con.Open();

                string query = $"SELECT* FROM atividade WHERE situacao = {Situacao.Pendente};";

                using (var cmd = new MySqlCommand(query, con))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            atividades.Add(new Atividade()
                            {
                                Id = reader.GetInt32("id"),
                                Titulo = reader.GetString("titulo"),
                                Situacao = (Situacao)reader.GetInt32("situacao")
                            });
                        }
                    } 
                }
            }  
            
            return atividades;
        }

    }
}
