using System;
using System.Text;

namespace ScaffoldCode.Infra.Helpers.Helpers
{
    // Para ajudar a contrução de Comandos Sql
    public class SqlBuilder
    {
        private String WherePref;
        private StringBuilder FSQL;

        public SqlBuilder()
        {
            FSQL = new StringBuilder();
            WherePref = " where ";
        }

        public SqlBuilder(String Sql)
            : this()
        {
            FSQL.Append(Sql);
            FSQL.Append(Environment.NewLine);
        }

        public void Append(String Sql)
        {
            FSQL.Append(Sql);
            FSQL.Append(Environment.NewLine);
        }

        public void AppendWhere(String Where)
        {
            FSQL.Append(WherePref);
            FSQL.Append(Where);
            FSQL.Append(Environment.NewLine);

            WherePref = " and ";        // Deixa para a próxima
        }

        public override String ToString()
        {
            return FSQL.ToString();
        }
    }
}
