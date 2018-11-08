using Hackaton.Contratos.Negocio;
using Hackaton.Contratos.Repositorio;
using Hackaton.Contratos.Uow;
using Hackaton.Entidades.Hackaton;
using Hackaton.Repositorio.Base;
using Hackaton.Repositorio.Contexto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;

namespace Hackaton.Repositorio.Uow
{
    public partial class UnitOfWork : BaseUow<ConexionDB>, IUnitOfWork
    {
        private ContextoBase _dbContext;
        IUnityContainer container;
        public UnitOfWork(IUnityContainer container)
        {
            _dbContext = new ConexionDB();
            this.ConfigurarDbContext(_dbContext);
            this.container = container;
        }
        

        public IAutosRepositorio autosRepositorio
        {
            get
            {
                return this.ObtenerRepositorio<IAutosRepositorio>(_dbContext, container);
            }
        }

        public void Dispose()
        {
            _dbContext.SaveChanges();
        }

        public void Guardar()
        {
            _dbContext.Dispose();
        }
    }
}
