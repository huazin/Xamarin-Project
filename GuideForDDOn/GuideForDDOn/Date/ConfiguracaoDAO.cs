using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using GuideForDDOn.Model;

namespace GuideForDDOn.Date
{
    public class ConfiguracaoDAO
    {
        static SQLiteConnection conexao;

        public static int Idioma { get; set; }

        public ConfiguracaoDAO(SQLiteConnection con)
        {
            conexao = con;
            Idioma = conexao.Table<Configuracao>().First().IdiomaPadrao;
        }

        public static void MudarIdioma(int i)
        {
            Idioma = i;
            conexao.Update(new Configuracao { Configuracaoid = 1,IdiomaPadrao = i });
        }
    }
}
