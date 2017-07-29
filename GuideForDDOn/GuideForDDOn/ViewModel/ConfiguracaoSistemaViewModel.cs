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
        private ObservableCollection<string> idiomaTxt;
        private int idiomaIndex;
        private List<LabelsIdiomas> Labels;
        private int selectedindex;
        private ContentPage Page;

        public int SelectedIndex
        {
            get { return selectedindex; }
            set { selectedindex = value; }
        }

        public string Lab
        {
            get { return Labels[ConfiguracaoDAO.Idioma -1].idiomalabel; }
        }

        public string LabBotao
        {
            get { return Labels[ConfiguracaoDAO.Idioma - 1].botaoconfirmar; }
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

        public ConfiguracaoSistemaViewModel(ContentPage page)
        {
            Page = page;
            SelectedIndex = ConfiguracaoDAO.Idioma - 1;
            Labels = new LabelsIdiomasDAO().GetAll();
            idiomaTxt = new ObservableCollection<string>();
            foreach(var lab in Labels)
            {
                idiomaTxt.Add(lab.nome);

            }
            Confirmar = new Command(ConfirmarFunAsync);
        }

        public void ConfirmarFunAsync()
        {
            ConfiguracaoDAO.MudarIdioma(SelectedIndex + 1);
            if (ConfiguracaoDAO.Idioma == 1) Page.DisplayAlert("Alerta", "Por Favor Reinicie o App", "Confirmar");
            else if (ConfiguracaoDAO.Idioma == 2) Page.DisplayAlert("Alert", "Please Reboot App!", "Confirm");
            LabelsIdiomasDAO.Reload();           
        }

        public ICommand Confirmar { get; protected set; }
    }
}
