using Dapper;
using ScaffoldCode.Domain.Entidades;
using ScaffoldCode.Domain.Interfaces.Repositorios;
using System.Collections.Generic;
using System.Linq;

namespace ScaffoldCode.Infra.Data.Dapper.Repositorios
{
    public class RepositorioTabelas : RepositorioBase, IRepositorioTabelas
    {
        public IEnumerable<objects> ObterTabelas()
        {
            using (var cn = GetConnection)
            {
                var tabelas = cn.Query<objects>("Select * from sys.objects o " +
                    "where o.type in ('P', 'U', 'V') ");

                return tabelas;
            }
        }

        public objects ObterTabela(string nome)
        {
            using (var cn = GetConnection)
            {
                var tabela = cn.Query<objects>(
                    "Select * from sys.objects o where o.type in ('P', 'U', 'V') " +
                    "Where o.name = @nome", nome)
                    .FirstOrDefault();

                return tabela;
            }
        }
    }
}
