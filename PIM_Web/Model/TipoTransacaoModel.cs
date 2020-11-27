using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PIM_Web.Model
{
    [Table("tb_tipo_transacao")]
    public class TipoTransacaoModel
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("descricao")]
        public string Descricao { get; set; }
    }
}
