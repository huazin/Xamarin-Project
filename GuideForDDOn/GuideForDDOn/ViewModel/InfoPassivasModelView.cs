using GuideForDDOn.Date;
using GuideForDDOn.Model;
using SQLite;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using GuideForDDOn.Views;
using Xamarin.Forms;
using System.ComponentModel;
using System.Linq;

namespace GuideForDDOn.ViewModel
{
    public class InfoPassivasModelView : INotifyPropertyChanged
    {
        private ObservableCollection<Passivas> listRef;
        public LabelsIdiomas Label { get { return LabelsIdiomasDAO.Label; } }

        public event PropertyChangedEventHandler PropertyChanged;

        private Passivas itemSelecao;
        private ContentPage page;

        public Passivas ItemSelecao
        {
            get
            {
                return itemSelecao;
            }
            set
            {
                itemSelecao = value;
                OnPropertyChanged("ItemSelecao");
            }
        }

        private void OnPropertyChanged(string nome)
        {
            Views.PassivasDetalhes tela = new Views.PassivasDetalhes(itemSelecao);
            this.page.Navigation.PushAsync(tela);
            this.page.FindByName<ListView>("ListaDaView").SelectedItem = null;
        }

        public ObservableCollection<Passivas> ListRef
        {
            get
            {
                return listRef;
            }
            set
            {
                listRef = value;
            }
        }

        public InfoPassivasModelView(Job Job, ContentPage Page)
        {
            this.page = Page;
            this.listRef = new ObservableCollection<Passivas>(PassivasDAO.PrePassivas.Where(p => p.id_Job == Job.Id_Job));
        }
    }
}
