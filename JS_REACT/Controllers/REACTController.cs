using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JS_REACT.Controllers
{
    public class REACTController : Controller
    {
        // GET: REACTController
        public ActionResult Index()
        {
            return View();
        }

        public IActionResult Counter()
        {
            return View();
        }

        // GET: REACTController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: REACTController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: REACTController/Create
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

        // GET: REACTController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: REACTController/Edit/5
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

        // GET: REACTController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: REACTController/Delete/5
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
