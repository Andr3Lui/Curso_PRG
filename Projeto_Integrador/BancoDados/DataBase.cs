﻿using MySql.Data.MySqlClient;

namespace Projeto_Integrador_Dominio.BancoDados
{
    internal class DataBase
    {
        private static readonly string ConnectionString = "datasource=localhost;username=root;password=1234;database=senac_pi;";

        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(ConnectionString);
        }

    }
}
