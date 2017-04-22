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
    public partial class HabilidadeDetalhes : ContentPage
    {
        public HabilidadeDetalhes(int Hab, SQLiteConnection Con)
        {
            HabilidadeDetalhesModelView vm = new HabilidadeDetalhesModelView(Hab, Con, this);
            BindingContext = vm;
            InitializeComponent();
        }
    }
}
