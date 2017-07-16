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
        public Home(SQLiteConnection con)
        {
            InitializeComponent();
           
            HomeViewModel vm = new HomeViewModel(this, con);
            BindingContext = vm;
        }
    }
}
