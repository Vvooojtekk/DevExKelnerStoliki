using KelnerStoliki.Models;
using KelnerStoliki.Models.DataGrid;
using KelnerStoliki.Models.SampleData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KelnerStoliki.Controllers {
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var stoliki = StolikLista.Stoliki;
            ViewBag.Stoliki = stoliki;
            return View();
        }

        public ActionResult Rachunek(int id)
        {
            var stoliki = StolikLista.Stoliki;
            ViewBag.Stoliki = stoliki;
            ViewBag.id = id+1;
            ViewBag.lista = ZamowieniaLista.Lista[id];
            return View();
        }
    }
}