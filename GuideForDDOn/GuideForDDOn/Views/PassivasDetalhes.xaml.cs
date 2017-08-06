using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GuideForDDOn.ViewModel;

using Xamarin.Forms;
using GuideForDDOn.Model;

namespace GuideForDDOn.Views
{
	public partial class PassivasDetalhes : ContentPage
	{
        public PassivasDetalhes(Passivas pas)
        {
            PassivasDetalheViewModel vm = new PassivasDetalheViewModel(pas, this);
            BindingContext = vm;
            InitializeComponent();
        }
    }
}
