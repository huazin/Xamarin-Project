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
        private LabelsIdiomas labels;

        private SQLiteConnection con { get { return ConfiguracaoDAO.conexao; } }
        public LabelsIdiomas Labels { get { return labels; } }

        public ICommand Classes { get; protected set; }
        public ICommand SmallMonster { get; protected set; }
        public ICommand BigMonster { get; protected set; }
        public ICommand Sobre { get; protected set; }
        public ICommand opcao { get; protected set; }

        public void OpcaoFun()
        {
            ConfiguracaoSistema Tela = new ConfiguracaoSistema();
            this.page.Navigation.PushAsync(Tela);
        }
        public void SobreFun()
        {
            Views.Sobre Tela = new Views.Sobre();
            this.page.Navigation.PushAsync(Tela);
        }
        public void ClassesFun()
        {
            Views.NovaTelaClasses tela = new NovaTelaClasses(con);
            this.page.Navigation.PushAsync(tela);
            //Views.Classes Tela = new Views.Classes(con);
            //this.page.Navigation.PushAsync(Tela);
        }
        public void SmallFun()
        {
            MonstrosSeparacao Tela = new MonstrosSeparacao();
            MonstroDAO dao = new MonstroDAO(con);
            ObservableCollection<Monstro> listRef = dao.GetAllEspecie(1);
            foreach (var a in listRef)
            {
                Tela.Children.Add(new MonstroSelecao(con, 1, a.especie));
            }
            this.page.Navigation.PushAsync(Tela);
        }
        public void BigFun()
        {
            MonstrosSeparacao Tela = new MonstrosSeparacao();
            MonstroDAO dao = new MonstroDAO(con);
            ObservableCollection<Monstro> listRef = dao.GetAllEspecie(2);
            foreach (var a in listRef)
            {
                Tela.Children.Add(new MonstroSelecao(con, 2, a.especie));
            }
            this.page.Navigation.PushAsync(Tela);
        }

        public HomeViewModel(ContentPage home)
        {
            this.page = home;

            labels = new LabelsIdiomasDAO().Get();

            Sobre = new Command(SobreFun);
            Classes = new Command(ClassesFun);
            SmallMonster = new Command(SmallFun);
            BigMonster = new Command(BigFun);
            opcao = new Command(OpcaoFun);
        }


    }
}
