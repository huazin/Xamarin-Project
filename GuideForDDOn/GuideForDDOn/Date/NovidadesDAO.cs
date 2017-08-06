using GuideForDDOn.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace GuideForDDOn.Date
{
    public class NovidadesDAO
    {
        public ObservableCollection<Novidades> GetAll()
        {
            return JsonConvert.DeserializeObject<ObservableCollection<Novidades>>(WebService.Get("Novidades", "?idioma=" + ConfiguracaoDAO.Idioma));
        }
    }
}
