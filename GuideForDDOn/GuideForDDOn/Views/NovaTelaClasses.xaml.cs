using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GuideForDDOn.ViewModel;
using SQLite;

using Xamarin.Forms;

namespace GuideForDDOn.Views
{
	public partial class NovaTelaClasses : ContentPage
	{
		public NovaTelaClasses (SQLiteConnection Con)
		{
            ClassesModelView vm = new ClassesModelView(this, Con);
            BindingContext = vm;
            InitializeComponent ();
		}
	}
}
