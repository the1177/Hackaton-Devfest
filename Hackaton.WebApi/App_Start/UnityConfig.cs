using Hackaton.Contratos.Negocio;
using Hackaton.Contratos.Repositorio;
using Hackaton.Contratos.Uow;
using Hackaton.Negocios.Autos;
using Hackaton.Negocios.Placas;
using Hackaton.Negocios.Policias;
using Hackaton.Repositorio;
using Hackaton.Repositorio.Uow;
using System.Web.Http;
using Unity;
using Unity.Injection;
using Unity.Lifetime;
using Unity.WebApi;

namespace Hackaton.WebApi
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();
            container.RegisterType<IAutosRepositorio, AutosRepositorio>();
            container.RegisterType<IAutosNegocio, AutosNegocio>();


            container.RegisterType<IPlacasRepositorio, PlacasRepositorio>();
            container.RegisterType<IPlacasNegocio, PlacasNegocio>();

            container.RegisterType<IPoliciasRepositorio, PoliciasRepositorio>();
            container.RegisterType<IPoliciasNegocio, PoliciasNegocio>();
            // register all your components with the container here
            container.RegisterType<IUnitOfWork, UnitOfWork>(new HierarchicalLifetimeManager());

            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}