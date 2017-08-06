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
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class NovidadesDetalhe : ContentPage
	{
		public NovidadesDetalhe (GuideForDDOn.Model.Novidades nov)
		{
            NovidadesDetalhesViewModel vm = new NovidadesDetalhesViewModel(this,nov);
            BindingContext = vm;
			InitializeComponent ();
		}
	}
}