using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace wsDDon.Models
{
    public class Passivas
    {
        public int id_Passiva { get; set; }
        public int id_Job { get; set; }
        public string nome { get; set; }
        public int ap { get; set; }
        public string nivel { get; set; }
        public string descricao { get; set; }
        public string monster5 { get; set; }
        public string monster6 { get; set; }

        public int idiomaId { get; set; }

        public int imagem { get; set; }

        public virtual Job Job { get; set; }
    }
}