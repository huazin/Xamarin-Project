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
        private ObservableCollection<Monstro> listRefCategoria;
        private string especie;
        private SQLiteConnection con;
        private MonstroDAO dao;
        private Monstro itemSelecao;
        private ObservableCollection<Monstro> listRef;
        private ContentPage page;
        public string Especie
        {
            get
            {
                return especie;
            }
            set
            {
                especie = value;
            }
        }
        public ObservableCollection<Monstro> ListRefCategoria
        {
            get
            {
                return listRefCategoria;
            }
            set
            {
                this.listRefCategoria = value;
            }
        }
        

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
            Views.MonstroDetalhes tela = new Views.MonstroDetalhes(itemSelecao.id_Monstro, con);
            this.page.Navigation.PushAsync(tela);
            this.page.FindByName<ListView>("ListaDaView").SelectedItem = null;
        }
        public MonstroSelecaoViewModel(SQLiteConnection Con, int tipo, string especie, ContentPage Page)
        {
            this.page = Page;
            this.con = Con;
            dao = new MonstroDAO(con);
            listRef = dao.GetAllForEspecie(tipo, especie);
        }
    }
}
