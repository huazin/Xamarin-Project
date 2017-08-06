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
        public LabelsIdiomas Label { get; set; }
        public InfoDasJobs ()
		{
            BindingContext = this;
			InitializeComponent ();
		}
	}
}
