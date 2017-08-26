using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace wsDDon.Models
{
    public class Job
    {

        public int Id_Job { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string DescricaoUSA { get; set; }
        public int Id_Tipo { get; set; }
        public int imagem { get; set; }


        public virtual TipoClasse TipoClasse { get; set; }
        public virtual IEnumerable<Passivas> Passivas { get; set; }
        public virtual IEnumerable<Habilidades> Habilidades { get; set; }
    }
}