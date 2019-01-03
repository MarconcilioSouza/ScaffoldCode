using System;
using System.Data.SqlClient;

namespace ScaffoldCode.Infra.Data.Dapper
{
    public class RepositorioBase
    {
        public static string connectionString = Environment.CurrentDirectory + @"\\ProjetoModelo.sqlite";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
