using GuideForDDOn.Date;
using Newtonsoft.Json;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

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

        public int imagem { get; set; }

        [JsonIgnore]
        public ImageSource Image
        {
            get
            {
                return ImageSource.FromFile(logos[imagem - 1]);
            }
        }

        [JsonIgnore]
        private String[] logos = new String[] { "pass.png", "pass2.png", "pass3.png", "pass4.png", "pass5.png", "pass6.png", "pass7.png", "pass8.png",
            "pass9.png" };

        [JsonIgnore]
        public LabelsIdiomas Label { get { return LabelsIdiomasDAO.Label; } }
    }
}
