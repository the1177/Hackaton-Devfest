using Hackaton.Contratos.Negocio;
using Hackaton.Contratos.Uow;
using Hackaton.Entidades.Hackaton;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using autos=Hackaton.Entidades.Hackaton;
namespace Hackaton.Negocios.Autos
{
    public class AutosNegocio : IAutosNegocio
    {

        private IUnitOfWork Uow;
        public AutosNegocio(IUnitOfWork Uow)
        {
            this.Uow = Uow;
        }

        public Entidades.Hackaton.Autos ObtenerPorId(int id)
        {
            autos.Autos prueba = this.Uow.autosRepositorio.Obtener(id);
            return prueba;
        }
    }
}
