using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ParcialPracticoWeb3.Web.Controllers
{
    public class PresentacionWeb3Controller : Controller
    {

        public ActionResult Bienvenidxs() {  return View(); }
        // GET: PresentacionWeb3Controller
        public ActionResult Index()
        {
            return View();
        }

        // GET: PresentacionWeb3Controller/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PresentacionWeb3Controller/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PresentacionWeb3Controller/Create
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

        // GET: PresentacionWeb3Controller/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PresentacionWeb3Controller/Edit/5
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

        // GET: PresentacionWeb3Controller/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PresentacionWeb3Controller/Delete/5
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
