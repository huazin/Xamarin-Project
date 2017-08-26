using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace wsDDon.Models
{
    public class TipoClasse
    {
        public int Id_Tipo { get; set; }
        public string Nome { get; set; }

        public virtual IEnumerable<Job> Jobs { get; set; }
    }
}