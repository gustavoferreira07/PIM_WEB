using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PIM_Web.Model
{
    [Table("tb_moeda")]
    public class MoedaModel
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("NomeMoeda")]
        public string NomeMoeda { get; set; }

        [Column("Valormoeda")]
        public decimal Valormoeda { get; set; }
    }
}
