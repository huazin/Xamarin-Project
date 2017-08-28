using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace wsDDon.Models
{
    public class Dicionario
    {
        public int id_Dicionario { get; set; }
        public string Palavra { get; set; }
        public string Significado { get; set; }

        public int idiomaid { get; set; }
    }
}