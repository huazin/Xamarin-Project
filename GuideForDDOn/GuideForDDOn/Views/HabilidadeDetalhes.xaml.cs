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
    public partial class HabilidadeDetalhes : ContentPage
    {
        public HabilidadeDetalhes(Habilidades Hab)
        {
            HabilidadeDetalhesModelView vm = new HabilidadeDetalhesModelView(Hab, this);
            BindingContext = vm;
            InitializeComponent();
        }
    }
}
