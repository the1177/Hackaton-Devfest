using Hackaton.Contratos.Repositorio;
using Hackaton.Entidades.Hackaton;
using Hackaton.Repositorio.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackaton.Repositorio
{
    public class PlacasRepositorio : RepositorioBase<Placas>, IPlacasRepositorio
    {
        public Placas placa(string placa)
        {
            Placas placaOrigen = this.DbSet.FirstOrDefault(a => a.PlacasAuto == placa);
            return placaOrigen;
        }
    }
}
