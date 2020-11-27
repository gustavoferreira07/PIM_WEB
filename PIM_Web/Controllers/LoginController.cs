using PIM_Web.Data.DAO;
using PIM_Web.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PIM_Web.Controllers
{
    public class LoginController : Controller
    {
        LoginDAO loginDAO = new LoginDAO();
        // GET: Login
        public ActionResult Logar()
        {

            return View();
        }

        [HttpPost]
        public ActionResult Logar(LoginModel loginModel)
        {
            try
            {
                loginDAO.ValidaLogin(loginModel);
                ViewBag.Sucess = "Login efetuado com sucesso";
                ViewBag.Error = "";
                return RedirectToAction("Index", "Home");

            }
            catch (Exception ex)
            {
                ViewBag.Error = "Login ou senha incorretos, tente novamente";
                ViewBag.Sucess = "";
            }
            return View();
        }

    }
}