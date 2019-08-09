using CAPATAZ.Aplicacion.UBI;
using CAPATAZ.Modelo.UBI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace NetWebApi.Controllers
{
    public class SaldosUbiController : ApiController
    {
        private readonly string mErr;
        readonly SaldosDeUbicacionesApi api;

        SaldosUbiController()
        {
            api = new SaldosDeUbicacionesApi(); 
            api.Login("SUPERVISOR", "", 2, ref mErr);
        }

        // GET: api/SaldosUbi
        public IEnumerable<SaldoUbi> Get()
        {
            return api.EntidadApi.GetListaOffLine(x => true);
        }

        // GET: api/SaldosUbi/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/SaldosUbi
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/SaldosUbi/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/SaldosUbi/5
        public void Delete(int id)
        {
        }
    }
}
