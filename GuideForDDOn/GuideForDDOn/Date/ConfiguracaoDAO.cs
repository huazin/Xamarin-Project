using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using GuideForDDOn.Model;

namespace GuideForDDOn.Date
{
    public class ConfiguracaoDAO
    {
        SQLiteConnection conexao;

        public static int Idioma { get; set; }

        public ConfiguracaoDAO(SQLiteConnection con)
        {
            conexao = con;
            Idioma = conexao.Table<Configuracao>().First().IdiomaPadrao;
        }

        public void MudarIdioma(int i)
        {
            Idioma = i;
        }
    }
}
