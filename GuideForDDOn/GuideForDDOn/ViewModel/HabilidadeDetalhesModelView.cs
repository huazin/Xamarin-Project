using GuideForDDOn.Date;
using GuideForDDOn.Model;
using SQLite;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using GuideForDDOn.Views;

namespace GuideForDDOn.ViewModel
{
    public class HabilidadeDetalhesModelView
    {
        private SQLiteConnection con;
        private HabilidadeDAO dao;
        private ObservableCollection<Habilidades> listRef;
        private string monstroParametro;
        private ContentPage page;

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
        public ICommand Monstro { get; protected set; }
        void MonstroFuncao(Object parametro)
        {
            if(parametro.ToString().Equals("Já Liberado o nivel 6"))
            {
                this.page.DisplayAlert("Informação","Habilidade já liberada","OK");
            }
            else if(parametro.ToString().Contains("Inimigos de BO"))
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
        public HabilidadeDetalhesModelView(int Job, SQLiteConnection Con, ContentPage Page)
        {
            this.page = Page;
            this.con = Con;
            this.dao = new HabilidadeDAO(con);
            this.listRef = dao.GetOne(Job);
            Monstro = new Command(MonstroFuncao);
        }
    }
}
