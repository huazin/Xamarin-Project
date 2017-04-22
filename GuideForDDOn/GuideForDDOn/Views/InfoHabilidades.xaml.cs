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
	public partial class InfoHabilidades : ContentPage
	{
        public InfoHabilidades(int job, SQLiteConnection con)
        {
            InfoHabilidadesViewModel vm = new InfoHabilidadesViewModel(job, con, this);
            BindingContext = vm;
            InitializeComponent();
        }
    }
}
