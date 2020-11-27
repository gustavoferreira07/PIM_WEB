using PIM_Web.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace PIM_Web.Data.Contexto
{
    public class db_context: DbContext
    {
        public db_context()
            : base("PIM_connection")
        {

        }
        public DbSet<CarteiraModel> CarteiraModels { get; set; }
        public DbSet<ClienteModel> ClienteModels { get; set; }
        public DbSet<EnderecoModel> EnderecoModels { get; set; }
        public DbSet<LoginModel> LoginModels { get; set; }
        public DbSet<MoedaModel> MoedaModels { get; set; }
        public DbSet<PlanoModel> PlanoModels { get; set; }
        public DbSet<TelefoneModel> TelefoneModels { get; set; }
        public DbSet<TipoTransacaoModel> TipoTransacaoModels { get; set; }
        public DbSet<TransacaoModel> TransacaoModels { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

        }
    }
}