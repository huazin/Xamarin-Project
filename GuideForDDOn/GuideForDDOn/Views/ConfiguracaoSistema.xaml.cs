using GuideForDDOn.ViewModel;
using SQLite;
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
	public partial class ConfiguracaoSistema : ContentPage
	{
		public ConfiguracaoSistema (SQLiteConnection con)
		{
            ConfiguracaoSistemaViewModel vm = new ConfiguracaoSistemaViewModel(con, this);
            BindingContext = vm;
            InitializeComponent();
        }
	}
}