using Hackaton.Contratos.Base;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;

namespace Hackaton.Repositorio.Base
{
    public class BaseUow<c> where c : DbContext, new()
    {
        protected void ConfigurarDbContext(DbContext contexto)
        {
            contexto.Database.Log = msg => Trace.WriteLine(msg);
            //this.IniciarDbContext(contexto);
        }
        internal T ObtenerRepositorio<T>(DbContext contexto, IUnityContainer container) where T : class
        {
            var repositorio = container.Resolve<T>();
            var establecerContexto = repositorio as IContexto;
            this.EstablecerContexto(establecerContexto, contexto);
            return repositorio;
        }
        private void EstablecerContexto(IContexto establecerContexto, DbContext context)
        {
            if (establecerContexto == null)
            {
                throw new NotImplementedException("Imposible setear context");
            }

            establecerContexto.EstablecerContexto(context);
        }
    }
}
