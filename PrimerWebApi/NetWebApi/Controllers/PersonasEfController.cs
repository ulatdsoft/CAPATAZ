using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.ModelBinding;
using System.Web.Http.OData;
using System.Web.Http.OData.Routing;
using NetWebApi.Data;
using NetWebApi.Models;

namespace NetWebApi.Controllers
{
    /*
    The WebApiConfig class may require additional changes to add a route for this controller. Merge these statements into the Register method of the WebApiConfig class as applicable. Note that OData URLs are case sensitive.

    using System.Web.Http.OData.Builder;
    using System.Web.Http.OData.Extensions;
    using NetWebApi.Models;
    ODataConventionModelBuilder builder = new ODataConventionModelBuilder();
    builder.EntitySet<Persona>("PersonasEf");
    config.Routes.MapODataServiceRoute("odata", "odata", builder.GetEdmModel());
    */
    public class PersonasEfController : ODataController
    {
        private NetWebApiContext db = new NetWebApiContext();

        // GET: odata/PersonasEf
        [EnableQuery]
        public IQueryable<Persona> GetPersonasEf()
        {
            return db.Personas;
        }

        // GET: odata/PersonasEf(5)
        [EnableQuery]
        public SingleResult<Persona> GetPersona([FromODataUri] int key)
        {
            return SingleResult.Create(db.Personas.Where(persona => persona.Id == key));
        }

        // PUT: odata/PersonasEf(5)
        public IHttpActionResult Put([FromODataUri] int key, Delta<Persona> patch)
        {
            Validate(patch.GetEntity());

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            Persona persona = db.Personas.Find(key);
            if (persona == null)
            {
                return NotFound();
            }

            patch.Put(persona);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PersonaExists(key))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return Updated(persona);
        }

        // POST: odata/PersonasEf
        public IHttpActionResult Post(Persona persona)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Personas.Add(persona);
            db.SaveChanges();

            return Created(persona);
        }

        // PATCH: odata/PersonasEf(5)
        [AcceptVerbs("PATCH", "MERGE")]
        public IHttpActionResult Patch([FromODataUri] int key, Delta<Persona> patch)
        {
            Validate(patch.GetEntity());

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            Persona persona = db.Personas.Find(key);
            if (persona == null)
            {
                return NotFound();
            }

            patch.Patch(persona);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PersonaExists(key))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return Updated(persona);
        }

        // DELETE: odata/PersonasEf(5)
        public IHttpActionResult Delete([FromODataUri] int key)
        {
            Persona persona = db.Personas.Find(key);
            if (persona == null)
            {
                return NotFound();
            }

            db.Personas.Remove(persona);
            db.SaveChanges();

            return StatusCode(HttpStatusCode.NoContent);
        }

        // GET: odata/PersonasEf(5)/Hijos
        [EnableQuery]
        public IQueryable<Persona> GetHijos([FromODataUri] int key)
        {
            return db.Personas.Where(m => m.Id == key).SelectMany(m => m.Hijos);
        }

        // GET: odata/PersonasEf(5)/Papa
        [EnableQuery]
        public SingleResult<Persona> GetPapa([FromODataUri] int key)
        {
            return SingleResult.Create(db.Personas.Where(m => m.Id == key).Select(m => m.Papa));
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool PersonaExists(int key)
        {
            return db.Personas.Count(e => e.Id == key) > 0;
        }
    }
}
