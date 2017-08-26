using GuideForDDOn.Date;
using Newtonsoft.Json;
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
        public string DescricaoUSA { get; set; }
        public int Id_Tipo { get; set; }

        [JsonIgnore]
        public string Des
        {
            get
            {
                if (ConfiguracaoDAO.Conf.IdiomaPadrao == 1)
                    return Descricao;
                return DescricaoUSA;
            }
        }


        public virtual TipoClasse TipoClasse { get; set; }
        public virtual ICollection<Passivas> Passivas { get; set; }
        public virtual ICollection<Habilidades> Habilidades { get; set; }

        public String Selecao()
        {
            return Id_Job + "";
        }
    }
}
