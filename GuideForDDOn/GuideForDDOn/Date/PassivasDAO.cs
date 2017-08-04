using GuideForDDOn.Model;
using Newtonsoft.Json;
using SQLite;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace GuideForDDOn.Date
{
    public class PassivasDAO
    {

        public ObservableCollection<Passivas> GetAll(int Id_Job)
        {
            return JsonConvert.DeserializeObject<ObservableCollection<Passivas>>(WebService.Get("Passivas", "?idioma=" + ConfiguracaoDAO.Idioma + "&id_Job=" + Id_Job));
        }
    }
}
