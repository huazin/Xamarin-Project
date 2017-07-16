using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace GuideForDDOn.Model
{
    public class Configuracao
    {
        [PrimaryKey]
        public int Configuracaoid { get; set; }
        public int IdiomaPadrao { get; set; } // 0 pt-br // 1 USA
    }
}
