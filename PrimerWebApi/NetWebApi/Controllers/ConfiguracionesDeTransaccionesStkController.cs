using CAPATAZ.Api.STK;
using CAPATAZ.Modelo.STK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace NetWebApi.Controllers
{
    public class ConfiguracionesDeTransaccionesStkController : ApiController
    {
        private readonly string mErr;
        readonly ConfiguracionDeTransaccionesStkApi api;

        ConfiguracionesDeTransaccionesStkController()
        {
            api = new ConfiguracionDeTransaccionesStkApi();
            api.Login("SUPERVISOR", "", 193, ref mErr);
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
