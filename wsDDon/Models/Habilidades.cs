using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace wsDDon.Models
{
    public class Habilidades
    {
        public int id_Habilidade { get; set; }
        public int id_Job { get; set; }
        public String nome { get; set; }
        public String descricao { get; set; }
        public String nivel { get; set; }
        public int nivelForSix { get; set; }
        public String obs { get; set; }
        public String addUp { get; set; }
        public String add6 { get; set; }

        public String monster5 { get; set; }
        public String monster6 { get; set; }
        public String monster7 { get; set; }
        public String monster8 { get; set; }
        public String monster9 { get; set; }

        public int idiomaId { get; set; }
        public int imagem { get; set; }

        public virtual Job Job { get; set; }
    }
}