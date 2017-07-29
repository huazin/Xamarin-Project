using GuideForDDOn.Model;
using Newtonsoft.Json;
using SQLite;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace GuideForDDOn.Date
{
    public class MonstroDAO
    {
        public Monstro GetMonstroExpecifico(string x)
        {
                Monstro Obj = JsonConvert.DeserializeObject<Monstro>(WebService.Get("Monstro", "?nome="+ x + "&idioma=" + ConfiguracaoDAO.Conf.IdiomaPadrao)); ;
                return Obj;
        }
        public ObservableCollection<Monstro> GetExpecifico(int id)
        {
            ObservableCollection<Monstro> Obj = JsonConvert.DeserializeObject<ObservableCollection<Monstro>>(WebService.Get("Monstro", ""+ id));
            return Obj;
        }

        internal ObservableCollection<Monstro> GetAllEspecie(int categoria,int idioma)
        {
            return JsonConvert.DeserializeObject<ObservableCollection<Monstro>>(WebService.Get("MonstrosEspecies", "?categoria=" + categoria + "&idioma=" + idioma));

        }

        internal ObservableCollection<Monstro> GetAllForEspecie(int categoria, string especie)
        {
            return JsonConvert.DeserializeObject<ObservableCollection<Monstro>>(WebService.Get("MonstrosEspecies", "?categoria=" + categoria + "&especie=" + especie + "&idioma=" + ConfiguracaoDAO.Conf.IdiomaPadrao));
        }
    }
}
