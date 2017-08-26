using GuideForDDOn.Date;
using GuideForDDOn.ViewModel;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace GuideForDDOn.Views
{
    public partial class Home : ContentPage
    {
        public Home()
        {
            InitializeComponent();
            SQLiteConnection con = DependencyService.Get<ISqLite>().GetConnection();
            ConfiguracaoDAO confi = new ConfiguracaoDAO(con);
            LabelsIdiomasDAO.Reload();
            HomeViewModel vm = new HomeViewModel(this);
            BindingContext = vm;
            NavigationPage.SetHasNavigationBar(this, true);
        }
    }
}
