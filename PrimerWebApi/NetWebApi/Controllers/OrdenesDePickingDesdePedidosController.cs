using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using CAPATAZ.Aplicacion.UBI.OPic;
using CAPATAZ.Modelo.UBI.OPic;

namespace NetWebApi.Controllers
{
    //[Route("api/[controller]")]
    public class OrdenesDePickingDesdePedidosController : ApiController
    {
        private readonly string mErr;
        readonly OrdenDePickingDesdePedidosApi api;

        OrdenesDePickingDesdePedidosController()
        {
            api = new OrdenDePickingDesdePedidosApi();
            api.Login("SUPERVISOR", "", 2, ref mErr);
        }

        // GET: api/OrdenesDePickingDesdePedidos
        public IEnumerable<OrdenDePickingDesdePedidos> Get()
        {
            return api.EntidadApi.GetListaOffLine(x => true);
        }

        // GET: api/OrdenesDePickingDesdePedidos/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/OrdenesDePickingDesdePedidos
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/OrdenesDePickingDesdePedidos/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        public void Delete(int id)
        {
        }
    }
}
