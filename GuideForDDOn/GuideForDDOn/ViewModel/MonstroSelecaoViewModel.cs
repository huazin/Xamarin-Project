using GuideForDDOn.Date;
using GuideForDDOn.Model;
using SQLite;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;
using GuideForDDOn.Views;

namespace GuideForDDOn.ViewModel
{
    public class MonstroSelecaoViewModel
    {
        private Monstro itemSelecao;
        private ObservableCollection<Monstro> listRef;
        private ContentPage page;
        public LabelsIdiomas Labels { get { return LabelsIdiomasDAO.Label; } }

        public ObservableCollection<Monstro> ListRef
        {
            get
            {
                return listRef;
            }
            set
            {
                this.listRef = value;
            }
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
            Views.MonstroDetalhes tela = new Views.MonstroDetalhes(itemSelecao.id_Monstro);
            this.page.Navigation.PushAsync(tela);
            this.page.FindByName<ListView>("ListaDaView").SelectedItem = null;
        }

        public MonstroSelecaoViewModel(int categoria, string especie, ContentPage Page)
        {
            this.page = Page;
            MonstroDAO dao = new MonstroDAO();
            listRef = dao.GetAllForEspecie(categoria, especie);
        }
    }
}
