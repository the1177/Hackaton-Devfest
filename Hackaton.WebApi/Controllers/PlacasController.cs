using Hackaton.Contratos.Negocio;
using Hackaton.Entidades.Hackaton;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Hackaton.WebApi.Controllers
{
    public class PlacasController : ApiController
    {
        private IPlacasNegocio placasNegocio;
        public PlacasController(IPlacasNegocio placasNegocio)
        {
            this.placasNegocio = placasNegocio;
        }

        [HttpGet]
        [Route("api/v1/usuario/{placas}")]
        public IHttpActionResult ObtenerPlacas(string placas)
        {
            try
            {
                List<Placas> Multas = this.placasNegocio.Multas(placas);
                return Ok(Multas);
            }
            catch (Exception ex)
            {

                throw;
            }
        }


    }
}
