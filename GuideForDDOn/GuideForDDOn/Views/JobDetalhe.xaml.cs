using GuideForDDOn.Model;
using GuideForDDOn.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GuideForDDOn.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class JobDetalhe : ContentPage
    {
        public JobDetalhe(Job job, ContentPage page)
        {
            try
            {
                JobDetalheViewModel vm = new JobDetalheViewModel(job, page);
                BindingContext = vm;
                InitializeComponent();
            }
            catch (Exception e)
            {
                string erro = e.Message;
            }
        }
    }
}