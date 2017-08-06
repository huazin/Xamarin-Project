using GuideForDDOn.Date;
using Newtonsoft.Json;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace GuideForDDOn.Model
{
    public class Passivas
    {
        [PrimaryKey, AutoIncrement]
        public int id_Passiva { get; set; }
        public int id_Job { get; set; }
        public string nome { get; set; }
        public int ap { get; set; }
        public string nivel { get; set; }
        public string descricao { get; set; }
        public string monster5 { get; set; }
        public string monster6 { get; set; }


        public int idiomaId { get; set; }

        public virtual Job Job { get; set; }
        [JsonIgnore]
        public LabelsIdiomas Label { get { return LabelsIdiomasDAO.Label; } }
    }
}
