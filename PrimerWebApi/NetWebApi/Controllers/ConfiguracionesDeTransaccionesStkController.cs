using CAPATAZ.Api.STK;
using CAPATAZ.Modelo.STK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace NetWebApi.Controllers
{    /// <summary>
     /// ANTENCION!!!
     /// Creado con: Web API 2 Controller with read/write actions.
     /// </summary>
    public class ConfiguracionesDeTransaccionesStkController : ApiController
    {
        readonly ConfiguracionDeTransaccionesStkApi api;

        ConfiguracionesDeTransaccionesStkController()
        {
            api = new ConfiguracionDeTransaccionesStkApi();
            api.Login("SUPERVISOR", "", 193, out _);
        }

        // GET: api/Sectores
        public IEnumerable<ConfiguracionDeTransaccionesStk> Get()
        {
            var lista = api.GetLista().ToList();
            return lista;
        }

        // GET: api/ConfiguracionesDeTransaccionesStk/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/ConfiguracionesDeTransaccionesStk
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/ConfiguracionesDeTransaccionesStk/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/ConfiguracionesDeTransaccionesStk/5
        public void Delete(int id)
        {
        }
    }
}
