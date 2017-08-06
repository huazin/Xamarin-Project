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

        public LabelsIdiomas Labels { get { return LabelsIdiomasDAO.Label; } }

        public ICommand Classes { get; protected set; }
        public ICommand SmallMonster { get; protected set; }
        public ICommand BigMonster { get; protected set; }
        public ICommand Sobre { get; protected set; }
        public ICommand opcao { get; protected set; }
        public ICommand News { get; protected set; }

        public void OpcaoFun()
        {
            ConfiguracaoSistema Tela = new ConfiguracaoSistema();
            this.page.Navigation.PushAsync(Tela);
        }
        public void NewsFun()
        {
            Views.Novidades Tela = new Views.Novidades();
            this.page.Navigation.PushAsync(Tela);
        }
        public void SobreFun()
        {
            Views.Sobre Tela = new Views.Sobre();
            this.page.Navigation.PushAsync(Tela);
        }
        public void ClassesFun()
        {
            Views.NovaTelaClasses tela = new NovaTelaClasses();
            this.page.Navigation.PushAsync(tela);


            //Views.Classes Tela = new Views.Classes(con);
            //this.page.Navigation.PushAsync(Tela);
        }
        public void SmallFun()
        {
            MonstrosSeparacao Tela = new MonstrosSeparacao();
            EspecieDao dao = new EspecieDao();
            ObservableCollection<Especie> listRef = dao.GetAll(1);
            foreach (var a in listRef)
            {
                Tela.Children.Add(new MonstroSelecao(1, a));
            }
            this.page.Navigation.PushAsync(Tela);
        }
        public void BigFun()
        {
            MonstrosSeparacao Tela = new MonstrosSeparacao();
            EspecieDao dao = new EspecieDao();
            ObservableCollection<Especie> listRef = dao.GetAll(2);
            foreach (var a in listRef)
            {
                Tela.Children.Add(new MonstroSelecao(2, a));
            }
            this.page.Navigation.PushAsync(Tela);
        }

        public HomeViewModel(ContentPage home)
        {
            this.page = home;

            Sobre = new Command(SobreFun);
            Classes = new Command(ClassesFun);
            SmallMonster = new Command(SmallFun);
            BigMonster = new Command(BigFun);
            opcao = new Command(OpcaoFun);
            News = new Command(NewsFun);
        }


    }
}
