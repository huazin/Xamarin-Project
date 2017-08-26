using GuideForDDOn.Model;
using Newtonsoft.Json;
using SQLite;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace GuideForDDOn.Date
{
    public class JobDAO
    {
        public static ObservableCollection<Job> PreJob { get; set; }

        
        public ObservableCollection<Job> GetAll()
        {
            return JsonConvert.DeserializeObject<ObservableCollection<Job>>(WebService.Get("Job",""));
        }

        public static void PreLoad()
        {
            PreJob = JsonConvert.DeserializeObject<ObservableCollection<Job>>(WebService.Get("Job", ""));
        }
    }
}
