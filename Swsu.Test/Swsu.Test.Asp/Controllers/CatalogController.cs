using Swsu.Test.Asp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Swsu.Test.Asp.Controllers
{
    /// <summary>
    /// Контроллер каталога
    /// </summary>
    public class CatalogController : Controller
    {
        GuitarContext db = new GuitarContext();

        /// <summary>
        /// Страница каталога гитар
        /// </summary>
        /// <param name="n">Номер страницы</param>
        /// <returns>Страницу каталога гитар</returns>
        public ActionResult Index(int page = 0)
        {
            IEnumerable<Guitar> guitars = null;
            int guitarsPerPage = 10;
            try
            {
                guitars = db.Guitars
                          .OrderBy(g => g.Model)
                          .Skip(page * guitarsPerPage)
                          .Take(6)
                          .ToList();
            }
            catch (ArgumentException)
            {
                guitars = db.Guitars
                          .OrderBy(g => g.Model)
                          .Skip(0 * guitarsPerPage)
                          .Take(6)
                          .ToList();

                page = 0;
            }
            finally
            {
                //ViewBag.Guitars = guitars;
                ViewBag.Page = ++page;
            }
            return View(guitars);
        }

        [HttpGet]
        public ActionResult Purchase(Guid id)
        {
            ViewBag.GuitarId = id;

            return View();
        }
    }
}