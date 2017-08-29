using GuideForDDOn.Date;
using GuideForDDOn.Model;
using SQLite;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using GuideForDDOn.Views;
using System.Linq;

namespace GuideForDDOn.ViewModel
{
    public class HabilidadeDetalhesModelView
    {

        private Habilidades Hab;
        private string monstroParametro;
        private ContentPage page;
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
        public Habilidades Habilidade
        {
            get
            {
                return Hab;
            }
            set
            {
                Hab = value;
            }
        }
        public ICommand Monstro { get; protected set; }
        void MonstroFuncao(Object parametro)
        {
            if(parametro.ToString().Equals("Já Liberado o nivel 6") || parametro.ToString().Equals("Level 6 released"))
            {
                this.page.DisplayAlert("Alert", Label.skillok, "OK");
            }
            else if(parametro.ToString().Contains("Inimigos de BO") || parametro.ToString().Contains("Enemies of BO"))
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
        public HabilidadeDetalhesModelView(Habilidades Hab,ContentPage Page)
        {
            this.page = Page;
            Habilidade = Hab;
            Monstro = new Command(MonstroFuncao);
            if(Habilidade.descricao.Contains("\""))
            { 
                foreach (var Palavra in DicionarioDAO.PreDicionario.Where(p => Habilidade.descricao.Contains("\"" + p.Palavra + "\"")))
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
