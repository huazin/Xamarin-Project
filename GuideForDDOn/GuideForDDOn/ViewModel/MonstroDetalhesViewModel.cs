using GuideForDDOn.Date;
using GuideForDDOn.Model;
using SQLite;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Xamarin.Forms;

namespace GuideForDDOn.ViewModel
{
    public class MonstroDetalhesViewModel
    {
        ContentPage page;
        private MonstroDAO dao;
        private ObservableCollection<Monstro> listRef;
        public  LabelsIdiomas Labels { get { return LabelsIdiomasDAO.Label; } }
        public Monstro itemSelecao { get; set; }

        public Monstro ItemSelecao
        {
            get
            {
                return itemSelecao;
            }
            set
            {
                itemSelecao = value;
                OnPropertyChanged();
            }
        }

        private void OnPropertyChanged()
        {
            this.page.FindByName<ListView>("ListaDaView").SelectedItem = null;
        }

        public ObservableCollection<Monstro> ListRef
        {
            get
            {
                return listRef;
            }
            set
            {
                listRef = value;
            }
        }

        public MonstroDetalhesViewModel(List<String> Nome, ContentPage Page)
        {
            this.page = Page;
            try
            {
                listRef = new ObservableCollection<Monstro>();
                foreach (var a in Nome)
                {
                    try
                    {
                        listRef.Add(MonstroDAO.PreMonstros.Where(p => p.apelido == a && p.idiomaid == ConfiguracaoDAO.Conf.IdiomaPadrao).First());
                    }
                    catch (Exception e)
                    {
                        this.page.DisplayAlert(LabelsIdiomasDAO.Label.Error, LabelsIdiomasDAO.Label.MonsterNotFound, "OK");
                    }
                }


            }
            catch (ExceptionNula e)
            {
            }
        }
        public MonstroDetalhesViewModel(Monstro x, ContentPage Page)
        {
            this.page = Page;
            listRef = new ObservableCollection<Monstro>();
            listRef.Add(x);
        }
    }
}
