using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using CoreWebClient.Models;
using CoreWebClient.Models.IYD;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CoreWebClient.Controllers
{
    public class SectoresController : Controller
    {
        // GET: Sectores
        public async Task<ActionResult> Index()
        {
            var httpClient = new HttpClient();
            var response = await httpClient.GetAsync(@"http://localhost:60868/api/Sectores");
            if (response.IsSuccessStatusCode)
            {
                var lista = await response.Content.ReadAsAsync<IEnumerable<Sector>>();
                return View(lista);
            }
            return RedirectToAction(nameof(Index));
        }

        // GET: Sectores/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Sectores/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Sectores/Create
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

        // GET: Sectores/Edit/5
        public async Task<ActionResult> Edit(int id)
        {
            var httpClient = new HttpClient();
            var response = await httpClient.GetAsync($@"http://localhost:60868/api/Sectores/{id}");
            if (response.IsSuccessStatusCode)
            {
                var entidad = await response.Content.ReadAsAsync<Sector>();
                return View(entidad);
            }
            return RedirectToAction(nameof(Index));
        }

        // POST: Sectores/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(int id, IFormCollection collection)
        {
            try
            {
                var httpClient = new HttpClient();
                var sector = new Sector();
                sector.Id = int.Parse(collection.First(x => x.Key == nameof(sector.Id)).Value);
                sector.Nombre = collection.First(x => x.Key == nameof(sector.Nombre)).Value;
                var response = await httpClient.PutAsJsonAsync($@"http://localhost:60868/api/Sectores/{id}", sector);
                if (response.IsSuccessStatusCode)
                {
                    return RedirectToAction(nameof(Index));
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Sectores/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Sectores/Delete/5
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
    }
}