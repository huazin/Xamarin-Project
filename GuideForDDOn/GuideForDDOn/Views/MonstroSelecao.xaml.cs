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
	public partial class MonstroSelecao : ContentPage
	{
        public MonstroSelecao(SQLiteConnection Con, int tipo, string especie)
        {
            MonstroSelecaoViewModel vm = new MonstroSelecaoViewModel(Con, tipo, especie, this);
            BindingContext = vm;
            InitializeComponent();
        }
    }
}
