using GuideForDDOn.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace GuideForDDOn.Views
{
    public partial class InfoDasJobs : TabbedPage
    {
        public InfoDasJobs()
        {
            try
            {

                BindingContext = this;
                InitializeComponent();
                this.Title = "Job";
            }
            catch (Exception e)
            {
                string erro = e.Message;
            }
        }
    }
}
