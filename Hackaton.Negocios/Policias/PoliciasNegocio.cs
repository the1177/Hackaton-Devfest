using Hackaton.Contratos.Negocio;
using Hackaton.Contratos.Uow;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackaton.Negocios.Policias
{
    public class PoliciasNegocio : IPoliciasNegocio
    {
        private IUnitOfWork Uow;
        public PoliciasNegocio(IUnitOfWork Uow)
        {
            this.Uow = Uow;
        }
    }
}
