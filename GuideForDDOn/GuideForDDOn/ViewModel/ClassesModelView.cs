using GuideForDDOn.Date;
using GuideForDDOn.Model;
using GuideForDDOn.Views;
using SQLite;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace GuideForDDOn.ViewModel
{
    public class ClassesModelView : INotifyPropertyChanged
    {
        private ContentPage page;
        private Job job;
        private JobDAO dao;
        private ObservableCollection<Job> listRef;

        public event PropertyChangedEventHandler PropertyChanged;

        private Job itemSelecao;

        public Job ItemSelecao
        {
            get
            {
                return itemSelecao;
            }
            set
            {
                itemSelecao = value;
                OnPropertyChangedAsync();
            }
        }

        public Job Job
        {
            get
            {
                return job;
            }
            set
            {
                job = value;
            }
        }

        public ObservableCollection<Job> ListRef
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

        private void OnPropertyChangedAsync()
        {
            //PropertyChanged(this, new PropertyChangedEventArgs (nome));
            Views.InfoDasJobs tela = new Views.InfoDasJobs();
            tela.Children.Add(new JobDetalhe(ItemSelecao, page));
            tela.Children.Add(new InfoHabilidades(ItemSelecao));
            tela.Children.Add(new InfoPassivas(ItemSelecao));
            this.page.FindByName<ListView>("ListaDaView").SelectedItem = null;
            page.Navigation.PushAsync(tela);
        }
        public ClassesModelView(ContentPage Page)
        {
            this.page = Page;
            this.dao = new JobDAO();
            this.listRef = dao.GetAll();
        }
    }
}
