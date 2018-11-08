using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackaton.Contratos.Base
{
    public interface IContexto
    {
        void EstablecerContexto(DbContext contexto);
    }
}
