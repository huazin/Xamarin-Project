using GuideForDDOn.Model;
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
        public MonstroSelecao(int tipo, Especie especie)
        {
            try
            {
                MonstroSelecaoViewModel vm = new MonstroSelecaoViewModel(tipo, especie, this);
                BindingContext = vm;
                InitializeComponent();
            }
            catch(Exception e)
            {
                var Msg = e.Message;
            }
        }
    }
}
