using GuideForDDOn.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GuideForDDOn.Views
{
	public partial class Novidades : ContentPage
	{
		public Novidades ()
		{
            NovidadesViewModel vm = new NovidadesViewModel(this);
            BindingContext = vm;
			InitializeComponent ();
		}
	}
}