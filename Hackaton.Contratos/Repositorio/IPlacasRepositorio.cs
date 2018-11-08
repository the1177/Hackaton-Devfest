using Hackaton.Contratos.Base;
using Hackaton.Entidades.Hackaton;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackaton.Contratos.Repositorio
{
    public interface IPlacasRepositorio : IRepositorioBase<Placas>
    {
        Placas placa(string placa);
    }
}
