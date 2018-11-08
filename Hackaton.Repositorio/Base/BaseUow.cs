using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackaton.Repositorio.Base
{
    public class BaseUow<c> where c : DbContext, new()
    {
    }
}
