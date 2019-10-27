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
            IEnumerable<Guitar> guitars = db.Guitars
                                        .OrderBy(g => g.Id)
                                        .Take(6)
                                        .Skip(page * 6);

            ViewBag.Guitars = guitars;
            ViewBag.Page = (page == 0)?1:page;
            return View();
        }
    }
}