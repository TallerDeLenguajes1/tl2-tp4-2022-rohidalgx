global using tp4.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace tp4.Controllers
{
    public class CadeteController : Controller
    {
        // GET: CadeteController

        private readonly static List<Cadete> cadetes = new List<Cadete>();
        private static int ID;

        //public IActionResult Listado()
        //{
        //    return View(cadetes);
        //}

        public IActionResult Listado()
        {
            return View(cadetes);
        }

        public IActionResult Alta()
        {
            return View();
        }

        public IActionResult Baja(int Id)
        {
            return View(Id);
        }

        [HttpPost]
        public IActionResult AltaOk(string Nombre, string Direccion, long Telefono)
        {
            int id = ID++;
            Cadete cadete = new Cadete(id, Nombre, Direccion, Telefono);
            cadetes.Add(cadete);
            return RedirectToAction("Listado");
        }

        [HttpPost]
        public IActionResult BajaOk(int Id)
        {
            cadetes.RemoveAll(i => i.getID() == Id);
            return RedirectToAction("Listado");
        }

        [HttpGet]

        public IActionResult Index()
        {
            return RedirectToAction("Listado");
        }


        // GET: CadeteController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CadeteController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CadeteController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CadeteController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CadeteController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CadeteController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CadeteController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }



   
    }
}
