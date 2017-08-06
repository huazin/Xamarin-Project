using GuideForDDOn.Date;
using GuideForDDOn.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;

namespace GuideForDDOn.ViewModel
{
    public class NovidadesViewModel
    {
        public ContentPage Page { get; set; }
        public LabelsIdiomas Label { get { return LabelsIdiomasDAO.Label; } }

        private ObservableCollection<Novidades> listRef;
        private Novidades itemSelecao;

        public ObservableCollection<Novidades>ListRef { get { return listRef; } set { listRef = value; }}


        public Novidades ItemSelecao
        {
            get
            {
                return itemSelecao;
            }
            set
            {
                itemSelecao = value;
                OnPropertyChanged();
            }
        }

        public void OnPropertyChanged()
        {
            GuideForDDOn.Views.NovidadesDetalhe tela = new GuideForDDOn.Views.NovidadesDetalhe(itemSelecao);
            Page.Navigation.PushAsync(tela);
            this.Page.FindByName<ListView>("ListaDaView").SelectedItem = null;
        }

        public NovidadesViewModel(ContentPage page)
        {
            Page = page;
            listRef = new NovidadesDAO().GetAll();
        }
    }
}
