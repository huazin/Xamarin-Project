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
        public LabelsIdiomasDAO()
        {
        }

        public LabelsIdiomas Get()
        {
            return ConfiguracaoDAO.conexao.Get<LabelsIdiomas>(p => p.idiomaid == ConfiguracaoDAO.Conf.IdiomaPadrao);
        }

        public List<LabelsIdiomas> GetAll()
        {
            return new List<LabelsIdiomas>(ConfiguracaoDAO.conexao.Table<LabelsIdiomas>());
        }
    }
}
