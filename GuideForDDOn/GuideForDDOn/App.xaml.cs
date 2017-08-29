using GuideForDDOn.Date;
using GuideForDDOn.Views;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace GuideForDDOn
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            PreLoads();
            Home page = new Home();
            NavigationPage tela = new NavigationPage(page);
            MainPage = tela;
        }

        public void PreLoads()
        {
            SQLiteConnection con = DependencyService.Get<ISqLite>().GetConnection();
            ConfiguracaoDAO.PreLoad(con);
            LabelsIdiomasDAO.Reload();
            SobresDAO.PreLoad();
            LabelsIdiomasDAO.PreLoad();
            EspecieDao.PreLoad();
            MonstroDAO.PreLoad();
            JobDAO.PreLoad();
            HabilidadeDAO.PreLoad();
            PassivasDAO.PreLoad();
            DicionarioDAO.PreLoad();

        }

        protected override void OnStart()
        {
            // Handle when your app start
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
        }
    }
}
