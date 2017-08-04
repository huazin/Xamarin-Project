using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace GuideForDDOn.Model
{
    public class Job
    {
        public int Id_Job { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public int Id_Tipo { get; set; }


        public virtual TipoClasse TipoClasse { get; set; }
        public virtual ICollection<Passivas> Passivas { get; set; }
        public virtual ICollection<Habilidades> Habilidades { get; set; }

        public String Selecao()
        {
            return Id_Job + "";
        }
    }
}
