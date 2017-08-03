using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace GuideForDDOn.Model
{
    public class TipoClasse
    {
        public int Id_Tipo { get; set; }
        public string Nome { get; set; }

        public virtual IEnumerable<Job> Jobs { get; set; }
    }
}
