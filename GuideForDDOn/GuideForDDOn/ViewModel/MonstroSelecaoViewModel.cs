using GuideForDDOn.Date;
using GuideForDDOn.Model;
using SQLite;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;
using GuideForDDOn.Views;
using System.Linq;

namespace GuideForDDOn.ViewModel
{
    public class MonstroSelecaoViewModel
    {
        private Monstro itemSelecao;
        private ObservableCollection<Monstro> listRef;
        private ContentPage page;
        private string especie;
        public LabelsIdiomas Labels { get { return LabelsIdiomasDAO.Label; } }

        public string Especie
        {
            get { return especie; } set { especie = value; }
        }
        public ObservableCollection<Monstro> ListRef
        {
            get{ return listRef;} set{ this.listRef = value;}
        }
        public Monstro ItemSelecao
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
            MonstroDetalhes tela = new MonstroDetalhes(itemSelecao);
            this.page.Navigation.PushAsync(tela);
            this.page.FindByName<ListView>("ListaDaView").SelectedItem = null;
        }

        public MonstroSelecaoViewModel(int categoria, Especie especie, ContentPage Page)
        {
            this.page = Page;
            this.Especie = especie.Nome;
            listRef = new ObservableCollection<Monstro>(MonstroDAO.PreMonstros.Where(p => p.categoria == categoria && p.Especie.Id_Especie == especie.Id_Especie));
        }
    }
}
