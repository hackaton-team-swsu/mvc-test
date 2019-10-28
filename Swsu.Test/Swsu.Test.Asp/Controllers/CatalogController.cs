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
        public ActionResult Index(int page = 1)
        {
            var pagesToShow = page;
            if (page < 1)
            {
                page = 1;
            }

            IEnumerable<Guitar> guitars = db.Guitars
                                        .OrderBy(g => g.Model)
                                        .Skip(--page * 6)
                                        .Take(6)
                                        .ToList();

            ViewBag.Guitars = guitars;
            ViewBag.Page = (pagesToShow < 1) ? 1 : pagesToShow;
            return View();
        }
    }
}