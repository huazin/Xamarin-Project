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
        static public ObservableCollection<Monstro> PreMonstros { get; set; }

        static public void PreLoad()
        {
            PreMonstros = JsonConvert.DeserializeObject<ObservableCollection<Monstro>>(
                    WebService.Get("Monstro", "?idioma=" + ConfiguracaoDAO.Conf.IdiomaPadrao + "&idiomas=ok")
                    );
        }

        public Monstro GetMonstroExpecifico(string x)
        {
                Monstro Obj = JsonConvert.DeserializeObject<Monstro>(WebService.Get("Monstro", "?apelido="+ x + "&idioma=" + ConfiguracaoDAO.Conf.IdiomaPadrao)); ;
                return Obj;
        }
        public ObservableCollection<Monstro> GetExpecifico(int id)
        {
            return JsonConvert.DeserializeObject<ObservableCollection<Monstro>>(WebService.Get("Monstro", ""+ id));
        }

        internal ObservableCollection<Monstro> GetAllForEspecie(int categoria, int especie)
        {
            return JsonConvert.DeserializeObject<ObservableCollection<Monstro>>(
                    WebService.Get("Monstro", "?categoria=" + categoria + "&id_especie=" + especie + "&idioma=" + ConfiguracaoDAO.Conf.IdiomaPadrao)
                    );
        }
    }
}
