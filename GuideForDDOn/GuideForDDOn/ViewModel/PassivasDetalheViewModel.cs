using GuideForDDOn.Date;
using GuideForDDOn.Model;
using GuideForDDOn.Views;
using SQLite;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace GuideForDDOn.ViewModel
{
    class PassivasDetalheViewModel
    {
        private ContentPage page;
        private SQLiteConnection con;
        private PassivasDAO dao;
        private ObservableCollection<Passivas> listRef;
        private string monstroParametro;

        public string MonstroParametro
        {
            get
            {
                return monstroParametro;
            }
            set
            {
                monstroParametro = value;
            }
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

        public ICommand Monstro { get; protected set; }
        void MonstroFuncao(Object parametro)
        {
            if (parametro.ToString().Equals("Já Liberado o nivel 6"))
            {
                this.page.DisplayAlert("Informação", "Habilidade já liberada", "OK");
            }
            else if (parametro.ToString().Contains("Inimigos de BO"))
            {
                this.page.DisplayAlert("Informação", "Essa habilidade precisa mata apenas Monstro com BO do nivel expecifico", "OK");
            }
            else
            {
                List<string> nomes = GuideForDDOn.Model.Monstro.SeparandoNomes(parametro);
                MonstroDetalhes tela = new MonstroDetalhes(con, nomes);
                this.page.Navigation.PushAsync(tela);
            }
        }
        public PassivasDetalheViewModel(int Pas, SQLiteConnection Con, ContentPage Page)
        {
            con = Con;
            page = Page;
            dao = new PassivasDAO(con);
            listRef = dao.GetOne(Pas);
            Monstro = new Command(MonstroFuncao);
        }
    }
}
