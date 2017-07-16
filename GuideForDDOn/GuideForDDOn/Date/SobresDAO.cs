using GuideForDDOn.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace GuideForDDOn.Date
{
    public class SobresDAO
    {
        public Sobres Get()
        {
            return ConfiguracaoDAO.conexao.Get<Sobres>(p => p.IdiomaId == ConfiguracaoDAO.Idioma);
        }
    }
}
