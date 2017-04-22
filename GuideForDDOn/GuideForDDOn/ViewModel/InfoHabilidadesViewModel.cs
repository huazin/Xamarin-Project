using GuideForDDOn.Date;
using GuideForDDOn.Model;
using SQLite;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;
using GuideForDDOn.Views;

namespace GuideForDDOn.ViewModel
{
    public class InfoHabilidadesViewModel : INotifyPropertyChanged
    {
        private SQLiteConnection con;
        private HabilidadeDAO dao;
        private ObservableCollection<Habilidades> listRef;
        private ContentPage page;

        public event PropertyChangedEventHandler PropertyChanged;

        private Habilidades itemSelecao;

        public Habilidades ItemSelecao
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
            Views.HabilidadeDetalhes tela = new Views.HabilidadeDetalhes(itemSelecao.id_Habilidade, con);
            this.page.Navigation.PushAsync(tela);
            this.page.FindByName<ListView>("ListaDaView").SelectedItem = null;
        }

        public ObservableCollection<Habilidades> ListRef
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


        public InfoHabilidadesViewModel(int Hab, SQLiteConnection Con, ContentPage Page)
        {
            this.con = Con;
            this.page = Page;
            this.dao = new HabilidadeDAO(con);
            this.listRef = dao.GetHabiEx(Hab);
        }
    }
}
