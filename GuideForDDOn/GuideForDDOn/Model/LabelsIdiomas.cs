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
        public int IdiomaId { get; set; }
        public string Nome { get; set; }
        public string classes { get; set; }
        public string MonstrosPequenos { get; set; }
        public string MonstrosGrandes { get; set; }
        public string Opcao { get; set; }
        public string Sobre { get; set; }

    }
}
