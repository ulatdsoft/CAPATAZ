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
    /// <summary>
    /// ANTENCION!!!
    /// Creado con: Web API 2 Controller with read/write actions.
    /// </summary>
    public class SectoresController : ApiController 
    {
        readonly SectorApi api;

        private SectoresController()
        {
            api = new SectorApi();
            if (!api.Login("SUPERVISOR", "", 2, out string mErr))
                throw new Exception(mErr);
        }

        // GET: api/Sectores
        public IEnumerable<Sector> Get()
        {
            return api.Gestor.GetLista();
        }

        // GET: api/Sectores/5
        public Sector Get(int id)
        {
            return api.Gestor.GetByKeyOffLine(id);
        }

        // POST: api/Sectores
        public void Post([FromBody]Sector value)
        {

        }

        // PUT: api/Sectores/5
        public void Put(int id, [FromBody]Sector value)
        {
            var entidad = api.Gestor.GetByKeyOffLine(id);
            value.ShallowCopyFieldsTo(entidad);
            api.Gestor.GuardarCambios();
        }

        // DELETE: api/Sectores/5
        public void Delete(int id)
        {
        }
    }
}
