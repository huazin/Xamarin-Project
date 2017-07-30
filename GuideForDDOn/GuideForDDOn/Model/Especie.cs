using System;
using System.Collections.Generic;
using System.Text;

namespace GuideForDDOn.Model
{
    public class Especie
    {
        public int Id_Especie { get; set; }
        public string Nome { get; set; }

        public virtual IEnumerable<Monstro> Monstros { get; set; }
    }
}
