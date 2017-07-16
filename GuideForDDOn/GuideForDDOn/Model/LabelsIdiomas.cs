using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace GuideForDDOn.Model
{
    public class LabelsIdiomas
    {
        [PrimaryKey, AutoIncrement]
        //Home
        public int idiomaid { get; set; }
        public string nome { get; set; }
        public string classes { get; set; }
        public string monstrospequenos { get; set; }
        public string monstrosgrandes { get; set; }
        public string opcao { get; set; }
        public string sobre { get; set; }
        public string idiomalabel { get; set; }//Configuracao de Sistema
        public string botaoconfirmar { get; set; }

    }
}
