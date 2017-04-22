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
        public int categoria { get; private set; }
        public string nome { get; private set; }
        public string apelido { get; private set; }
        public string especie { get; private set; }
        public string pontoFraco { get; private set; }
        public string obs { get; private set; }
        public string elementoFraco { get; private set; }
        public string drop { get; private set; }
        public string localizacao { get; private set; }

        public Monstro()
        {

        }

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
