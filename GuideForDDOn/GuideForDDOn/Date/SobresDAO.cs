using GuideForDDOn.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace GuideForDDOn.Date
{
    public class SobresDAO
    {
        public static Sobres PreSobres { get; set; }

        public static void PreLoad()
        {
            PreSobres =  JsonConvert.DeserializeObject<Sobres>(WebService.Get("Sobre", ConfiguracaoDAO.Conf.IdiomaPadrao.ToString()));
        }

        public Sobres Get()
        {
            return JsonConvert.DeserializeObject<Sobres>(WebService.Get("Sobre", ConfiguracaoDAO.Conf.IdiomaPadrao.ToString()));
        }
    }
}
