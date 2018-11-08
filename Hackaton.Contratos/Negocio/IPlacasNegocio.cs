using Hackaton.Entidades.Hackaton;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackaton.Contratos.Negocio
{
    public interface IPlacasNegocio
    {
        Placas placa(string Placa);
        List<Entidades.Hackaton.Placas> Multas(string placa);
    }
}
