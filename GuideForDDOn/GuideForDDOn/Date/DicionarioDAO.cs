using GuideForDDOn.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace GuideForDDOn.Date
{
    public class DicionarioDAO
    {
        public static ObservableCollection<Dicionario> PreDicionario { get; set; }

        public static void PreLoad()
        {
            PreDicionario = JsonConvert.DeserializeObject<ObservableCollection<Dicionario>>(WebService.Get("Dicionario", "?idioma=" + ConfiguracaoDAO.Idioma));
        }
    }
}
