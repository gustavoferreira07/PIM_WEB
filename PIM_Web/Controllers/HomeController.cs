using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PIM_Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Relatorio()
        {
            return View();
        }

        public ActionResult Transacao()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult ConsultaTransacao()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}