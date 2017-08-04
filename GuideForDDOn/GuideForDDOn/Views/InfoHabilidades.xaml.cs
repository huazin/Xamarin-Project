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
	public partial class InfoHabilidades : ContentPage
	{
        public InfoHabilidades(Job job)
        {
            InfoHabilidadesViewModel vm = new InfoHabilidadesViewModel(job, this);
            BindingContext = vm;
            InitializeComponent();
        }
    }
}
