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
	public partial class NovoInfoJob : ContentPage
	{
		public NovoInfoJob (SQLiteConnection con, string nome)
		{
			InitializeComponent ();
            InfoJobViewModel vm = new InfoJobViewModel(con, nome);
            BindingContext = vm;
		}
	}
}
