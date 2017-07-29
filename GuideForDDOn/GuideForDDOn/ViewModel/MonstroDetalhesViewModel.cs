using GuideForDDOn.Date;
using GuideForDDOn.Model;
using SQLite;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace GuideForDDOn.ViewModel
{
    public class MonstroDetalhesViewModel
    {
        ContentPage page;
        private MonstroDAO dao;
        private ObservableCollection<Monstro> listRef;
        private LabelsIdiomas labels;

        public LabelsIdiomas Labels { get { return LabelsIdiomasDAO.Label; } }

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
                this.dao = new MonstroDAO();
                int i = 0;
                listRef = new ObservableCollection<Monstro>();
                foreach (var a in Nome)
                {
                    try
                    {
                        listRef.Add(dao.GetMonstroExpecifico(Nome[i]));
                    }
                    catch (ExceptionNula e)
                    {
                        this.page.DisplayAlert(LabelsIdiomasDAO.Label.Error, LabelsIdiomasDAO.Label.MonsterNotFound, "OK");
                    }
                    i++;
                }


            }
            catch (ExceptionNula e)
            {
            }
        }
        public MonstroDetalhesViewModel(int x)
        {
            this.dao = new MonstroDAO();
            listRef = dao.GetExpecifico(x);
        }
    }
}
