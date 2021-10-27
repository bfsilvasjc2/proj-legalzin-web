using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PimWeb.Controllers
{
    public class InteressesController : Controller
    {
        // GET: InteressesController
        public ActionResult Index()
        {
            return View();
        }

        // GET: InteressesController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: InteressesController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: InteressesController/Create
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

        // GET: InteressesController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: InteressesController/Edit/5
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

        // GET: InteressesController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: InteressesController/Delete/5
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
