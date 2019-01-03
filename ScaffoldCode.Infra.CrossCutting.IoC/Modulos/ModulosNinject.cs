using Ninject.Modules;
using ScaffoldCode.Domain.Interfaces.Repositorios;
using ScaffoldCode.Infra.Data.Dapper;

namespace ScaffoldCode.Infra.CrossCutting.IoC.Modulos
{
    public class ModulosNinject : NinjectModule
    {
        public override void Load()
        {
            Bind(typeof(IRepositorioBase<>)).To(typeof(RepositorioBase));
            Bind<IRepositorioColunas>().To<RepositorioColunas>();
        }
    }
}
