using CAPATAZ.Api.STK;
using CAPATAZ.Datos.Utils;
using CAPATAZ.Modelo.STK;
using CAPATAZ.Modelo.UBI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace NetWebApi.Controllers
{
    /// <summary>
    /// ANTENCION!!!
    /// Creado con: Web API 2 Controller with read/write actions.
    /// </summary>
    public class DepositosController : ApiController
    {
        readonly DepositoApi api;

        protected DepositosController()
        {
            api = new DepositoApi();
            api.Login("SUPERVISOR", "", 247, out _);
        }

        // GET: api/Depositos
        public IEnumerable<Deposito> Lista()
        {
            return api.GetListaOffLine(x => true);
        }

        // GET: api/Depositos/5
        public Deposito Get(string id)
        {
            var dep = api.GetByKeyOffLine(id);
            var js = dep.GenJson(2);
            return js.GetObjectFromJson<Deposito>();
        }

        public Ubicacion GetUbicacion(string codDeposito, int numeroUbi)
        {
            var ubi = api.GetUbicacion(codDeposito, numeroUbi);
            var js = ubi.GenJson(2);
            return js.GetObjectFromJson<Ubicacion>();
        }

        // POST: api/Depositos
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Depositos/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Depositos/5
        public void Delete(int id)
        {
        }
    }
}
