using CAPATAZ.Aplicacion.IYD;
using CAPATAZ.Modelo.IYD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace NetWebApi.Controllers
{
    public class SectoresController : ApiController
    {
        private readonly string mErr;
        readonly SectoresApi api;

        SectoresController()
        {
            api = new SectoresApi();
            api.Login("SUPERVISOR", "", 2, ref mErr);
        }

        // GET: api/Sectores
        public IEnumerable<Sector> Get()
        {
            return api.EntidadApi.GetLista();
        }

        // GET: api/Sectores/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Sectores
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Sectores/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Sectores/5
        public void Delete(int id)
        {
        }
    }
}
