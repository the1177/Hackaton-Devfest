using Hackaton.Contratos.Negocio;
using Hackaton.Contratos.Uow;
using Hackaton.Entidades.Hackaton;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackaton.Negocios.Placas
{
    public class PlacasNegocio : IPlacasNegocio
    {
        private IUnitOfWork Uow;
        public PlacasNegocio(IUnitOfWork Uow)
        {
            this.Uow = Uow;
        }

        public Entidades.Hackaton.Placas placa(string Placa)
        {
            return this.Uow.placasRepositorio.placa(Placa);
        }

        public List<Entidades.Hackaton.Placas> Multas(string placa)
        {
            var storeProcedure = "dbo.multasPorIdPlaca @placa";
            List<SqlParameter> parametrosMulta= new List<SqlParameter>();
            parametrosMulta.Add(new SqlParameter("@idRolUsuario", placa));

            List<Entidades.Hackaton.Placas> multa = this.Uow.placasRepositorio.GetFromDatabaseWithQuery<Entidades.Hackaton.Placas>(storeProcedure, parametrosMulta);
            return multa;
        }
    }
}
