using GuideForDDOn.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace GuideForDDOn.Date
{   
    public class EspecieDao
    {
        public ObservableCollection<Especie> GetAll(int i)
        {
            return JsonConvert.DeserializeObject<ObservableCollection<Especie>>(WebService.Get("MonstrosEspecies", "?categoria=" + i + "&idioma=" + ConfiguracaoDAO.Conf.IdiomaPadrao));
        }
    }
}
