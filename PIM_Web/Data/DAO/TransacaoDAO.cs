using PIM_Web.Data.Contexto;
using PIM_Web.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PIM_Web.Data.DAO
{
    public class TransacaoDAO
    {
        public List<TransacaoModel> Retornatransacoes()
        {
            using (var context = new db_context())
            {
                var retorno = context.TransacaoModels.ToList();
                
                return retorno;
            }
        }

        public TransacaoModel RetornaListTransacoesDetalhes()
        {
            using (var context = new db_context())
            {
                TransacaoModel transacao = new TransacaoModel();
                transacao.MoedaModel = context.MoedaModels.ToList();
                transacao.TipoTransacaoModel = context.TipoTransacaoModels.ToList();

                return transacao;
            }
        }

        public void AdicionaTransacao(TransacaoModel transacao)
        {
            try
            {
                using (var context = new db_context())
                {
                    context.TransacaoModels.Add(transacao);
                    context.SaveChanges();
                }
            }
            catch (Exception)
            {

                throw;
            }
            
        }
    }
}