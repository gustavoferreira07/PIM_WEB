using System;
using System.Collections.Generic;
using System.Text;

namespace PIM_Web.Model
{
    public class CarteiraModel
    {
        public int Id { get; set; }
        public int IdCliente { get; set; }
        public int IdMoeda { get; set; }
        public decimal QuantidadeAcoes { get; set; }
    }
}
