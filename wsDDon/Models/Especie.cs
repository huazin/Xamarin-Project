using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace wsDDon.Models
{
    public class Especie
    {
        public int Id_Especie { get; set; }
        public string Nome { get; set; }

        public virtual IEnumerable<Monstro> Monstro { get; set; }
    }
}