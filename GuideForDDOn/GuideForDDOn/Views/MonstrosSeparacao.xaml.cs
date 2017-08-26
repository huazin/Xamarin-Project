using GuideForDDOn.Date;
using GuideForDDOn.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace GuideForDDOn.Views
{
    public partial class MonstrosSeparacao : TabbedPage
    {
        public LabelsIdiomas Label { get{ return LabelsIdiomasDAO.Label; } }

        public MonstrosSeparacao()
        {
            BindingContext = this;
            InitializeComponent();
            this.Title = Label.monstrospequenos;
        }
    }
}
