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
    public partial class InfoPassivas : ContentPage
    {
        public InfoPassivas(Job job)
        {
            try
            {
                InfoPassivasModelView vm = new InfoPassivasModelView(job, this);
                BindingContext = vm;
                InitializeComponent();
            }
            catch (Exception e)
            {

            }
        }
    }
}
