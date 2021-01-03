using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotnetBookStore.Controllers
{
    public class BookGenresController : Controller
    {
        // GET: BookGenresController
        public ActionResult Index()
        {
            return View();
        }

        // GET: BookGenresController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: BookGenresController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BookGenresController/Create
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

        // GET: BookGenresController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: BookGenresController/Edit/5
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

        // GET: BookGenresController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: BookGenresController/Delete/5
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
