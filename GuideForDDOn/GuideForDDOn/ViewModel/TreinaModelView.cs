using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace GuideForDDOn.ViewModel
{
    public class TreinaModelView
    {
        private ContentPage page;
        public ICommand  Monstra; 
        public TreinaModelView(ContentPage Page)
        {
            this.page = Page;

            Monstra = new Command(() =>
            {
                page.DisplayAlert("Titulo", "Botao Clicado", "Ok");
            });
        }
    }
}
