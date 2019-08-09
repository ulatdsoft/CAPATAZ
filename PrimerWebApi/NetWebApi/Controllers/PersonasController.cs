using NetWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace NetWebApi.Controllers
{
    public class PersonasController : ApiController
    {
        static List<Persona> personas = GetPersonas();

        static List<Persona> GetPersonas()
        {
            var ps = new List<Persona>
            {
                new Persona
                {
                    Id = 1,
                    Nombre = "DANIEL",
                    Nacimiento = new DateTime(1979, 6,  5),
                },
                new Persona
                {
                    Id = 2,
                    Nombre = "MAURICIO",
                    Nacimiento = new DateTime(1970, 6, 11)
                },
                new Persona
                {
                    Id = 11,
                    Nombre = "CAMILA",
                    Nacimiento = new DateTime(2011, 9, 26),
                }
            };

            var dani = ps.First(p => p.Id == 1);
            var cande = ps.First(p => p.Id == 11);

            dani.Hijos.Add(cande);
            cande.Papa = dani;

            return ps;
        }

        // GET: api/Personas
        public IEnumerable<Persona> Get()
        {
            return personas;
        }

        // GET: api/Personas/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Personas
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Personas/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Personas/5
        public void Delete(int id)
        {
        }
    }
}
