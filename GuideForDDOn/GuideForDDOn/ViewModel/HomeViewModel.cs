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
    public class HomeViewModel
    {
        private ContentPage page;
        private SQLiteConnection con;
        private LabelsIdiomas labels;

        public LabelsIdiomas Labels { get { return labels; } }

        public ICommand Classes { get; protected set; }
        public ICommand SmallMonster { get; protected set; }
        public ICommand BigMonster { get; protected set; }
        public ICommand Sobre { get; protected set; }
        public ICommand opcao { get; protected set; }
        public HomeViewModel(ContentPage home, SQLiteConnection con)
        {
            this.page = home;
            this.con = con;

            labels = new LabelsIdiomasDAO(con).Get();

            Sobre = new Command(() =>
            {
                Views.Sobre Tela = new Views.Sobre();
                this.page.Navigation.PushAsync(Tela);
            });
            Classes = new Command(() =>
            {
                Views.NovaTelaClasses tela = new NovaTelaClasses(con);
                this.page.Navigation.PushAsync(tela);
                //Views.Classes Tela = new Views.Classes(con);
                //this.page.Navigation.PushAsync(Tela);
            });
            SmallMonster = new Command(() =>
            {
                MonstrosSeparacao Tela = new MonstrosSeparacao();
                MonstroDAO dao = new MonstroDAO(con);
                ObservableCollection<Monstro> listRef = dao.GetAllEspecie(1);
                foreach (var a in listRef)
                {
                    Tela.Children.Add(new MonstroSelecao(con, 1, a.especie));
                }
                this.page.Navigation.PushAsync(Tela);
            });
            BigMonster = new Command(() =>
            {
                MonstrosSeparacao Tela = new MonstrosSeparacao();
                MonstroDAO dao = new MonstroDAO(con);
                ObservableCollection<Monstro> listRef = dao.GetAllEspecie(2);
                foreach (var a in listRef)
                {
                    Tela.Children.Add(new MonstroSelecao(con, 2, a.especie));
                }
                this.page.Navigation.PushAsync(Tela);
            });
            opcao = new Command(() =>
            {
                ConfiguracaoSistema Tela = new ConfiguracaoSistema(con);
                this.page.Navigation.PushAsync(Tela);
            });
        }
    }
}
