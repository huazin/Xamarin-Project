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
	public partial class Classes : ContentPage
	{
        public Classes(SQLiteConnection Con)
        {
            ClassesModelView vm = new ClassesModelView(this, Con);
            BindingContext = vm;
            InitializeComponent();
        }
    }
}
