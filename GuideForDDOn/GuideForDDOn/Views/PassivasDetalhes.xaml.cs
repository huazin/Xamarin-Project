using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GuideForDDOn.ViewModel;

using Xamarin.Forms;

namespace GuideForDDOn.Views
{
	public partial class PassivasDetalhes : ContentPage
	{
        public PassivasDetalhes(int Pas, SQLiteConnection Con)
        {
            PassivasDetalheViewModel vm = new PassivasDetalheViewModel(Pas, Con, this);
            BindingContext = vm;
            InitializeComponent();
        }
    }
}
