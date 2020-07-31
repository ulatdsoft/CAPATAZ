using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CAPATAZ.Modelo.IYD;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CoreWebApi.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class SectoresController : ControllerBase
    {
        // GET: api/Sectores
        [HttpGet]
        public IEnumerable<Sector> Get()
        {
            return new Sector[] {
                new Sector {Id=1, Nombre = "Sector UNO"},
                new Sector {Id=2, Nombre = "Sector DOS"},
                new Sector {Id=3, Nombre = "Sector TRES"},
            };
        }

        // GET: api/Sectores/5
        [AllowAnonymous]
        [HttpGet("{id}", Name = "Get")]
        public Sector Get(int id)
        {
            return new Sector { Id = id, Nombre = $"Sector {id}" };
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
