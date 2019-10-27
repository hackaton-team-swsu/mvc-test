using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Swsu.Test.Asp.Controllers
{
    public class CatalogController : Controller
    {
        // GET: Catalog
        public ActionResult Index(int n)
        {
            ViewBag.Page = n;
            return View();
        }
    }
}