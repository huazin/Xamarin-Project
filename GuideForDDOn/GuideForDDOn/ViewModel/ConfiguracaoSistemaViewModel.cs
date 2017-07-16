using GuideForDDOn.Date;
using GuideForDDOn.Model;
using SQLite;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace GuideForDDOn.ViewModel
{
    public class ConfiguracaoSistemaViewModel
    {
        private SQLiteConnection con;
        private ObservableCollection<string> idiomaTxt;
        private int idiomaIndex;
        private List<LabelsIdiomas> Labels;
        

        public string Lab
        {
            get { return Labels[ConfiguracaoDAO.Idioma -1].idiomalabel; }
        }

        public string LabBotao
        {
            get { return Labels[ConfiguracaoDAO.Idioma].botaoconfirmar; }
        }

        public ObservableCollection<string> IdiomaTxt
        {
            get { return idiomaTxt; }
            set { IdiomaTxt = value; }
        }

        public int IdiomaIndex
        {
            get { return IdiomaIndex; }
            set { IdiomaIndex = value; }
        }

        public ConfiguracaoSistemaViewModel(SQLiteConnection Con)
        {
            con = Con;
            Labels = new LabelsIdiomasDAO(con).GetAll();
            idiomaTxt = new ObservableCollection<string>();
            foreach(var lab in Labels)
            {
                idiomaTxt.Add(lab.nome);

            }

        }

        public void ConfirmarFun()
        {
            ConfiguracaoDAO.Idioma = idiomaIndex;
        }

        public ICommand Confirmar { get; protected set; }
    }
}
