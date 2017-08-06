using GuideForDDOn.Model;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace GuideForDDOn.ViewModel
{
    public class NovidadesDetalhesViewModel
    {
        public ContentPage Page { get; set; }
        public LabelsIdiomas Label { get; set; }
        public Novidades News { get; set; }
        public HtmlWebViewSource Video { get; set; }
        public ImageSource Imagem { get; set; }
        public NovidadesDetalhesViewModel(ContentPage page, Novidades nov)
        {
            Page = page;
            News = nov;

            Video = new HtmlWebViewSource();
            Video.Html = @"<iframe width = ""350"" height = ""350"" src = """+ nov.URLVideo + @""" allowfullscreen ></ iframe >";
            Imagem = ImageSource.FromUri(new Uri(nov.URL));

        }

    }
}
