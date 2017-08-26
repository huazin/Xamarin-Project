using GuideForDDOn.Model;
using Newtonsoft.Json;
using SQLite;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;

namespace GuideForDDOn.Date
{
    public class LabelsIdiomasDAO
    {
        static public LabelsIdiomas Label { get; set; }
        static public List<LabelsIdiomas> PreLabels { get; set; }

        static public void Reload()
        {
            Label = JsonConvert.DeserializeObject<LabelsIdiomas>(WebService.Get("labelsidiomas", ConfiguracaoDAO.Conf.IdiomaPadrao.ToString()));
            //Label =  ConfiguracaoDAO.conexao.Get<LabelsIdiomas>(p => p.idiomaid == ConfiguracaoDAO.Conf.IdiomaPadrao);
        }

        static public void PreLoad()
        {
            PreLabels = JsonConvert.DeserializeObject<List<LabelsIdiomas>>(WebService.Get("labelsidiomas", string.Empty));
        }
    }
}
