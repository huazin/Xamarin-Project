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
        public MonstroDetalhes(SQLiteConnection Con, List<string> Nome)
        {
            MonstroDetalhesViewModel vm = new MonstroDetalhesViewModel(Con, Nome,this);
            BindingContext = vm;
            InitializeComponent();
        }
        public MonstroDetalhes(SQLiteConnection Con, int x)
        {
            MonstroDetalhesViewModel vm = new MonstroDetalhesViewModel(Con, x);
            BindingContext = vm;
            InitializeComponent();
        }
        public MonstroDetalhes(int x, SQLiteConnection Con)
        {
            MonstroDetalhesViewModel vm = new MonstroDetalhesViewModel(x, Con);
            BindingContext = vm;
            InitializeComponent();
        }
    }
}
