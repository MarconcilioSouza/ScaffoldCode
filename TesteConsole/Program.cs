using ScaffoldCode.Infra.Data.Dapper.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var tabelas = new RepositorioTabelas().ObterTabelas();
        }
    }
}
