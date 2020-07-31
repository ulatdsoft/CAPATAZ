using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using CAPATAZ.Api.UBI.OPic;
using CAPATAZ.Datos.Utils;
using CAPATAZ.Modelo.UBI.OPic;

namespace NetWebApi.Controllers
{
    /// <summary>
    /// ANTENCION!!!
    /// Creado con: Web API 2 Controller with read/write actions.
    /// </summary>
    
    //[Route("api/[controller]")]
    public class OrdenesDePickingDesdePedidosController : ApiController
    {
        readonly OPicPedApi api;

        OrdenesDePickingDesdePedidosController()
        {
            api = new OPicPedApi();
            api.Login("SUPERVISOR", "", 247, out _);
        }

        // GET: api/OrdenesDePickingDesdePedidos
        public IEnumerable<OrdenDePickingDesdePedidos> Get()
        {
            return api.Gestor.GetListaOffLine(x => true);
        }

        // GET: api/OrdenesDePickingDesdePedidos/5
        public OrdenDePickingDesdePedidos Get(string id)
        {
            var oPicPed = api.Gestor.GetByKeyOffLine(id);
            var js = oPicPed.GenJson(2);
            return js.GetObjectFromJson<OrdenDePickingDesdePedidos>();
        }


        //public IHttpActionResult Get(int id)
        //{
        //    var oPicPed = api.GetFromIdOffLine(id);
        //    return Ok(oPicPed.GenJson(3).GetObjectFromJson<OrdenDePickingDesdePedidos>());
        //}

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
