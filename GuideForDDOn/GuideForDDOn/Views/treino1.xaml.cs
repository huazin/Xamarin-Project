using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace GuideForDDOn.Views
{
	public partial class treino1 : ContentPage
	{
        public string NomeM, DataM, NacionalidadeM;
		public treino1 (string Nome, string Data, string Nacionalidade)
		{
			BindingContext = this;
            this.NomeM = Nome;
            this.DataM = Data;
            this.NacionalidadeM = Nacionalidade;
            DisplayAlert(Nome, NomeM, "OK");

            InitializeComponent();
        }
	}
}
