using System;
using System.Text;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;

namespace ScaffoldCode.Infra.Data.Dapper
{
    public class RepositorioBase : IDisposable
    {
        public IDbConnection GetConnection
        {
            get
            {
                StringBuilder ConnString = new StringBuilder("Server=");
                ConnString.Append(@"DESKTOP-G63G7KL\SQLEXPRESS");
                ConnString.Append(";database=");
                ConnString.Append("dne");
                ConnString.Append(";User ID=");
                ConnString.Append("sa");
                ConnString.Append(";Password=");
                ConnString.Append("123");

                return new SqlConnection(ConnString.ToString());

                //return new SqlCeConnection(ConfigurationManager.
                //    ConnectionStrings["Entities"]
                //    .ConnectionString);
            }
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
