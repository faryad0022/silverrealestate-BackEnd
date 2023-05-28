using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RealEstateUI.Controllers.RealEstateService
{
    public class RealEstateServiceController : Controller
    {
        // GET: RealEstateServiceController
        public ActionResult Index()
        {
            return View();
        }

        // GET: RealEstateServiceController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: RealEstateServiceController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: RealEstateServiceController/Create
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

        // GET: RealEstateServiceController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: RealEstateServiceController/Edit/5
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

        // GET: RealEstateServiceController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: RealEstateServiceController/Delete/5
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
