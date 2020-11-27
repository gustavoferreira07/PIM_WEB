using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PIM_Web.Model
{
    [Table("tb_login")]
    public class LoginModel
    {
        [Key]
        [Column("Id")]
        public int Id { get; set; }

        [Column("Usuario")]
        public string Usuario { get; set; }

        [Column("Senha")]
        public string Senha { get; set; }

        [Column("IdCliente")]
        public int IdCliente { get; set; }
    }
}
