﻿using GuideForDDOn.Model;
using Newtonsoft.Json;
using SQLite;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace GuideForDDOn.Date
{
    public class HabilidadeDAO
    {

        public ObservableCollection<Habilidades> GetAll(int id_Job)
        {
            //return new ObservableCollection<Habilidades>(conexao.Table<Habilidades>());
            return JsonConvert.DeserializeObject<ObservableCollection<Habilidades>>(WebService.Get("Habilidades", "?idioma=" + ConfiguracaoDAO.Idioma + "&id_Job=" + id_Job));
        }
    }
}
