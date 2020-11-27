using PIM_Web.Data.DAO;
using PIM_Web.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PIM_Web.Controllers
{
    public class TransacaoController : Controller
    {
        TransacaoDAO transacaoModel = new TransacaoDAO();
        // GET: Transacao
        public ActionResult AdicionaTransacao()
        {
           
            return View(transacaoModel.RetornaListTransacoesDetalhes());
        }

        [HttpPost]
        public ActionResult AdicionaTransacao(TransacaoModel transacao)
        {
            try
            {
                transacaoModel.AdicionaTransacao(transacao);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            return View();
        }

        public ActionResult ConsultaTransacao()
        {
            
            return View(transacaoModel.Retornatransacoes());
        }
    }
}