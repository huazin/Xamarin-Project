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
	public partial class MonstroDetalhes : ContentPage
	{
        public MonstroDetalhes(List<string> Nome)
        {
            MonstroDetalhesViewModel vm = new MonstroDetalhesViewModel(Nome,this);
            BindingContext = vm;
            InitializeComponent();
        }
        public MonstroDetalhes(Monstro x)
        {
            MonstroDetalhesViewModel vm = new MonstroDetalhesViewModel(x,this);
            BindingContext = vm;
            InitializeComponent();
        }
    }
}
