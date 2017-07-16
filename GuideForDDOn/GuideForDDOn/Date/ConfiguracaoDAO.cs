using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using GuideForDDOn.Model;

namespace GuideForDDOn.Date
{
    public class ConfiguracaoDAO
    {
        public static SQLiteConnection conexao;
        public static Configuracao Conf;

        public static int Idioma { get { return Conf.IdiomaPadrao; } }
        public static double Versao { get { return Conf.Versao; } }

        public ConfiguracaoDAO(SQLiteConnection con)
        {
            conexao = con;
            Conf = conexao.Table<Configuracao>().First();
        }

        public static void MudarIdioma(int i)
        {
            Conf.IdiomaPadrao = i;
            conexao.Update(Conf);
        }
    }
}
