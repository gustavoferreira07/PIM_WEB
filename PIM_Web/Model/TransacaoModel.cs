using PIM_Web.Data.Contexto;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace PIM_Web.Model
{
    [Table("tb_transacao")]
    public class TransacaoModel
    {
        [Key]
        [Column("Id")]
        public int Id { get; set; }

        [Column("DataTransacao")]
        public DateTime DataTransacao { get; set; }

        [Column("IdCliente")]
        //[ForeignKey("FK_idCli")
        public int IdCliente { get; set; }

        [Column("TipoTransacao")]
        //[ForeignKey("FK__tb_transa__IdCli__4CA06362")]
        public int TipoTransacao { get; set; }

        [Column("IdMoeda")]
        //[ForeignKey("FK__tb_transa__IdMoe__4E88ABD4")]
        public int IdMoeda { get; set; }

        [Column("QuantidadeAcoes")]
        public decimal QuantidadeAcoes { get; set; }

        [NotMapped]
        
        public List <TipoTransacaoModel> TipoTransacaoModel { get; set; }
        [NotMapped]
        public List <MoedaModel> MoedaModel { get; set; }





    }
}
