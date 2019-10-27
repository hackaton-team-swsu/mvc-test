using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Swsu.Test.Asp.Models;

namespace Swsu.Test.Asp.Controllers
{
    public class HomeController : Controller
    { 
    /// создаем контекст данных
        GuitarContext db = new GuitarContext();

        public ActionResult Index()
        {
            /// получаем из бд все объекты Book
            IEnumerable<Guitar> guitars = db.Guitars;
            /// передаем все объекты в динамическое свойство Books в ViewBag
            ViewBag.Guitars = guitars;

            /// возвращаем представление
            return View();
        }

        [HttpGet]
        public ActionResult Buy(int id = 0)
        {
            ViewBag.GuitarId = id;
            return View();
        }

        [HttpPost]
        public string Buy(Purchase purchase)
        {
            purchase.Date = DateTime.Now;
            /// добавляем информацию о покупке в базу данных
            db.Purchases.Add(purchase);
            /// сохраняем в бд все изменения
            db.SaveChanges();
            return "Спасибо," + purchase.Person + ", за покупку!";
        }

    }
}