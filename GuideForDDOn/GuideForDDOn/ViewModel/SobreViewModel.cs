using GuideForDDOn.Date;
using GuideForDDOn.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace GuideForDDOn.ViewModel
{
    public class SobreViewModel
    {
        public Sobres Sobre{ get; set; }
        public LabelsIdiomas Labels { get { return LabelsIdiomasDAO.Label; } }
        public string Links { get { return Sobre.Links.Replace("%", Environment.NewLine); } }
        public string Equip { get { return Sobre.Equip.Replace("%", Environment.NewLine); } }
        public string Versao { get { return (Labels.Versao + " " + ConfiguracaoDAO.Versao).Replace(",","."); } }

        public SobreViewModel()
        {
            Sobre = new SobresDAO().Get();
        }
    }
}
