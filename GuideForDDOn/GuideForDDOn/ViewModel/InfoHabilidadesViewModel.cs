﻿using GuideForDDOn.Date;
using GuideForDDOn.Model;
using SQLite;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;
using GuideForDDOn.Views;
using System.Linq;

namespace GuideForDDOn.ViewModel
{
    public class InfoHabilidadesViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<Habilidades> listRef;
        private ContentPage page;
        public LabelsIdiomas Label { get { return LabelsIdiomasDAO.Label; } }

        public event PropertyChangedEventHandler PropertyChanged;

        private Habilidades itemSelecao;

        public Habilidades ItemSelecao
        {
            get
            {
                return itemSelecao;
            }
            set
            {
                itemSelecao = value;
                OnPropertyChanged("ItemSelecao");
            }
        }

        private void OnPropertyChanged(string nome)
        {
            Views.HabilidadeDetalhes tela = new Views.HabilidadeDetalhes(itemSelecao);
            this.page.Navigation.PushAsync(tela);
            this.page.FindByName<ListView>("ListaDaView").SelectedItem = null;
        }

        public ObservableCollection<Habilidades> ListRef
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

        public InfoHabilidadesViewModel(Job job,ContentPage Page)
        {
            this.page = Page;
            listRef = new ObservableCollection<Habilidades> (HabilidadeDAO.PreHabilidades.Where(p => p.id_Job == job.Id_Job));
        }
    }
}
