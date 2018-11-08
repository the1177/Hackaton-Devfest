using Hackaton.Contratos.Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Hackaton.WebApi.Controllers
{
    public class PoliciasController : ApiController
    {
        public IPoliciasNegocio policiasNegocio;
        public PoliciasController(IPoliciasNegocio policiasNegocio)
        {
            this.policiasNegocio = policiasNegocio;
        }

        [HttpGet]
        [Route("api/v1/policias")]
        public IHttpActionResult ObtenerPolicias()
        {
            try
            {
                return Ok();
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
