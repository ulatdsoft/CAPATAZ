using CAPATAZ.Api.IYD;
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

        private SectoresController()
        {
            api = new SectoresApi();
            if (!api.Login("SUPERVISOR", "", 2, ref mErr))
                throw new Exception(mErr);
        }

        // GET: api/Sectores
        public IEnumerable<Sector> Get()
        {
            return api.EntidadApi.GetLista();
        }

        // GET: api/Sectores/5
        public Sector Get(int id)
        {
            return api.EntidadApi.GetFromId(id);
        }

        // POST: api/Sectores
        public void Post([FromBody]Sector value)
        {

        }

        // PUT: api/Sectores/5
        public void Put(int id, [FromBody]Sector value)
        {
            var entidad = api.EntidadApi.GetFromId(id);
            value.ShallowCopyFieldsTo(entidad);
            api.EntidadApi.Actualizar(entidad);
        }

        // DELETE: api/Sectores/5
        public void Delete(int id)
        {
        }
    }
}
