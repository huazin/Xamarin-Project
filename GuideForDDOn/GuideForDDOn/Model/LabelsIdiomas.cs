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

        //Configuracao de Sistema
        public string idiomalabel { get; set; }
        public string botaoconfirmar { get; set; }

        //Sobre
        public string Devs { get; set; }
        public string Versao { get; set; }
        public string Links { get; set; }
        public string Equip { get; set; }

    }
}
