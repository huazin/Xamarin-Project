using GuideForDDOn.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace GuideForDDOn.Views
{
	public partial class Treino : ContentPage
	{
		public Treino ()
		{
			InitializeComponent();
		}
        private string txtNome, txtData, txtNacionalidade;
        private void cadastrar (object sender, EventArgs e)
        {
            this.txtNome = this.Nome.Text;
            this.txtData = this.Nacionalidade.Text;
            this.txtNacionalidade = this.Nacionalidade.Text;

            treino1 oT = new treino1(txtNome,txtData,txtNacionalidade);
            this.Navigation.PushAsync(oT);

        }
    }
}
