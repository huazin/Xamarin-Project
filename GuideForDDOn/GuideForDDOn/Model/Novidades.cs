using GuideForDDOn.Date;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace GuideForDDOn.Model
{
    public class Novidades
    {
        public int Id_Novidades { get; set; }
        public string Titulo { get; set; }
        public DateTime Data { get; set; }
        public string Descricao { get; set; }
        public bool Excluido { get; set; }
        public int IdiomaId { get; set; }
        public string URL { get; set; }
        public string URLVideo { get; set; }

        [JsonIgnore]
        public LabelsIdiomas Label { get { return LabelsIdiomasDAO.Label; } }
    }
}
