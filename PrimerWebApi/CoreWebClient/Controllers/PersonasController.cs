using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using CoreWebClient.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CoreWebClient.Controllers
{
    public class PersonasController : Controller
    {
        //static List<Persona> personas = GetPersonas();

        //static List<Persona> GetPersonas()
        //{
        //    var ps = new List<Persona>
        //    {
        //        new Persona
        //        {
        //            Id = 1,
        //            Nombre = "DANIEL",
        //            Nacimiento = new DateTime(1979, 6,  5),
        //        },
        //        new Persona
        //        {
        //            Id = 2,
        //            Nombre = "MAURICIO",
        //            Nacimiento = new DateTime(1970, 6, 11)
        //        },
        //        new Persona
        //        {
        //            Id = 11,
        //            Nombre = "CAMILA",
        //            Nacimiento = new DateTime(2011, 9, 26),
        //        }
        //    };

        //    var dani = ps.First(p => p.Id == 1);
        //    var cande = ps.First(p => p.Id == 11);

        //    dani.Hijos.Add(cande);
        //    cande.Papa = dani;

        //    return ps;
        //}

        // GET: Personas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Personas/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Personas/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Personas/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Personas/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Personas/Edit/5
        public ActionResult Edit(int id)
        {
            //var persona = personas.FirstOrDefault(p => p.Id == id);
            //return View(persona);
            return View();
        }

        // POST: Personas/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                //var persona = personas.FirstOrDefault(p => p.Id == id);
                //persona.Nombre = collection.First(x => x.Key == nameof(persona.Nombre)).Value;
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
        // GET: Personas
        public async Task<ActionResult> Index()
        {
            var httpClient = new HttpClient();
            var response = await httpClient.GetAsync(@"http://localhost:60868/api/Personas");
            if (response.IsSuccessStatusCode)
            {
                var personas = await response.Content.ReadAsAsync<IEnumerable<Persona>>();
                return View(personas);
            }
            return RedirectToAction(nameof(Index));
        }

    }
}