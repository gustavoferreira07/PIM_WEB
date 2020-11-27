using PIM_Web.Data.Contexto;
using PIM_Web.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PIM_Web.Data.DAO
{
    public class LoginDAO
    {
        public void ValidaLogin(LoginModel loginModel)
        {
            using(var context = new db_context())
            {
                var xai = context.LoginModels.ToList();
                var user = context.LoginModels.Where(l => l.Usuario == loginModel.Usuario && l.Senha == loginModel.Senha).FirstOrDefault();
                if (user == null)
                    throw new Exception();
            }
        }
    }
}