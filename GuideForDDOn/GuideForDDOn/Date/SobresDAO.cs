using GuideForDDOn.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace GuideForDDOn.Date
{
    public class SobresDAO
    {
        public Sobres Get()
        {
            return JsonConvert.DeserializeObject<Sobres>(WebService.Get("Sobre", ConfiguracaoDAO.Conf.IdiomaPadrao.ToString()));
        }
    }
}
