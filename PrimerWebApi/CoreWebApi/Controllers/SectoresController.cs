using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CAPATAZ.Modelo.IYD;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CoreWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SectoresController : ControllerBase
    {
        // GET: api/Sectores
        [HttpGet]
        public IEnumerable<Sector> Get()
        {
            return new Sector[] {
                new Sector {Id=1, Nombre = "Sector UNO"}
            };
        }

        // GET: api/Sectores/5
        [HttpGet("{id}", Name = "Get")]
        public Sector Get(int id)
        {
            return new Sector { Id = 1, Nombre = "Sector UNO" };
        }

        // POST: api/Sectores
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Sectores/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
