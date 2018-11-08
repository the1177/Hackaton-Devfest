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
    public class AutoController : ApiController
    {
        private IAutosNegocio autosNegocio;
        public AutoController(IAutosNegocio autosNegocio)
        {
            this.autosNegocio = autosNegocio;
        }


        [HttpGet]
        [Route("api/v1/usuario/{id}/consultas")]
        public IHttpActionResult Obtener(int id)
        {
            try
            {
                Autos resultado = this.autosNegocio.ObtenerPorId(id);
                return Ok(resultado);
            }
            catch (Exception ex)
            {

                return InternalServerError();
            }
        }

    }
}
