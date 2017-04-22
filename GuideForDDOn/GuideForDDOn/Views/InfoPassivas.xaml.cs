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
	public partial class InfoPassivas : ContentPage
	{
        public InfoPassivas(int job, SQLiteConnection con)
        {
            InfoPassivasModelView vm = new InfoPassivasModelView(job, con,this);
            BindingContext = vm;
            InitializeComponent();
        }
    }
}
