using Newtonsoft.Json;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace GuideForDDOn.Model
{
    public class Monstro
    {
        [PrimaryKey, AutoIncrement]
        public int id_Monstro { get; set; }

        public int categoria { get; set; }
        public string nome { get; set; }
        public string apelido { get; set; }
        public int Id_Especie { get; set; }
        public virtual Especie Especie { get; set; }
        public string pontoFraco { get; set; }
        public string obs { get; set; }
        public string elementoFraco { get; set; }
        public string drop { get; set; }
        public string localizacao { get; set; }

        public int idiomaid { get; set; }


        public static List<string> SeparandoNomes(Object x)
        {
            string Parametro = x.ToString();
            Parametro = Regex.Replace(Parametro, @"[\d-]", String.Empty);
            Parametro = Parametro.Replace(" de nivel  ou superior", String.Empty);
            Parametro = Parametro.Replace("  ", String.Empty);
            Parametro = Parametro.Replace(Environment.NewLine, ",");
            List<string> listaDeNomes = Parametro.Split(',').ToList(); ;
            return listaDeNomes;
        }
    }
}
