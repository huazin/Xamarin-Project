using GuideForDDOn.Model;
using Newtonsoft.Json;
using SQLite;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace GuideForDDOn.Date
{
    class JobDAO
    {
        private ObservableCollection<Job> lista;

        public ObservableCollection<Job> Lissta
        {
            get
            {
                if (lista == null)
                    lista = GetAll();
                return lista;
            }
            private set
            {
                this.lista = value;
            }
        }

        public ObservableCollection<Job> GetAll()
        {
            return JsonConvert.DeserializeObject<ObservableCollection<Job>>(WebService.Get("Job",""));
        }
    }
}
