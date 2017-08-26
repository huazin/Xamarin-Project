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
        public static ObservableCollection<Especie> PreEspecieSmall { get; set; }
        public static ObservableCollection<Especie> PreEspecieBig { get; set; }

        public static void PreLoad()
        {
            PreEspecieSmall = JsonConvert.DeserializeObject<ObservableCollection<Especie>>(WebService.Get("MonstrosEspecies", "?categoria=" + 1 + "&idioma=" + ConfiguracaoDAO.Conf.IdiomaPadrao));
            PreEspecieBig = JsonConvert.DeserializeObject<ObservableCollection<Especie>>(WebService.Get("MonstrosEspecies", "?categoria=" + 2 + "&idioma=" + ConfiguracaoDAO.Conf.IdiomaPadrao));
        }


        public ObservableCollection<Especie> GetAll(int i)
        {
            return JsonConvert.DeserializeObject<ObservableCollection<Especie>>(WebService.Get("MonstrosEspecies", "?categoria=" + i + "&idioma=" + ConfiguracaoDAO.Conf.IdiomaPadrao));
        }
    }
}
