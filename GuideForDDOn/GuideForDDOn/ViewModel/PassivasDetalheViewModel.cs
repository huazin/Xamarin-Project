using GuideForDDOn.Date;
using GuideForDDOn.Model;
using GuideForDDOn.Views;
using SQLite;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace GuideForDDOn.ViewModel
{
    class PassivasDetalheViewModel
    {
        private ContentPage page;
        private Passivas passivas;
        private string monstroParametro;
        public LabelsIdiomas Label { get { return LabelsIdiomasDAO.Label; } }
        public string Dicionario { get; set; }

        public string MonstroParametro
        {
            get
            {
                return monstroParametro;
            }
            set
            {
                monstroParametro = value;
            }
        }
        public Passivas Passivas
        {
            get
            {
                return passivas;
            }
            set
            {
                passivas = value;
            }
        }

        public ICommand Monstro { get; protected set; }
        void MonstroFuncao(Object parametro)
        {
            if (parametro.ToString().Contains("Inimigos de BO"))
            {
                this.page.DisplayAlert("Alert", Label.skillbo, "OK");
            }
            else
            {
                List<string> nomes = GuideForDDOn.Model.Monstro.SeparandoNomes(parametro);
                MonstroDetalhes tela = new MonstroDetalhes(nomes);
                this.page.Navigation.PushAsync(tela);
            }
        }
        public PassivasDetalheViewModel(Passivas pas, ContentPage Page)
        {
            page = Page;
            Passivas = pas;
            Monstro = new Command(MonstroFuncao);
            if (Passivas.descricao.Contains("\""))
            {
                foreach (var Palavra in DicionarioDAO.PreDicionario.Where(p => Passivas.descricao.Contains("\"" + p.Palavra + "\"")))
                {
                    if (Dicionario == string.Empty)
                        Dicionario = Palavra.Significado;
                    else
                        Dicionario += Environment.NewLine + Palavra.Significado;
                }
            }
        }
    }
}
