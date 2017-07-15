using GuideForDDOn.Model;
using SQLite;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace GuideForDDOn.Date
{
    public class LabelsIdiomasDAO
    {
        SQLiteConnection conexao;
        public LabelsIdiomasDAO(SQLiteConnection con)
        {
            conexao = con;
        }

        public LabelsIdiomas Get()
        {
            return conexao.Get<LabelsIdiomas>(p => p.IdiomaId == ConfiguracaoDAO.Idioma);
        }
    }
}
