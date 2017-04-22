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
        private SQLiteConnection con;
        private Job job;
        private JobDAO dao;
        private ObservableCollection<Job> listRef;

        public ICommand BotaoClasse { get; private set; }

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
                OnPropertyChangedAsync("ItemSelecao");
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

        private void OnPropertyChangedAsync(String nome)
        {
            //PropertyChanged(this, new PropertyChangedEventArgs (nome));
            //Views.InfoDasJobs tela = new Views.InfoDasJobs();
            //tela.Children.Add(new InfoHabilidades(/*itemSelecao.id_Job*/ Convert.ToInt32(nome), con));
            //tela.Children.Add(new InfoPassivas(/*itemSelecao.id_Job*/ Convert.ToInt32(nome), con));
            this.page.Navigation.PushAsync(new NovoInfoJob(con,nome));
            ////this.page.FindByName<ListView>("ListaDaView").SelectedItem = null;
        }
        public ClassesModelView(ContentPage Page, SQLiteConnection Con)
        {
            this.page = Page;
            this.con = Con;
            this.dao = new JobDAO(con);
            this.listRef = dao.GetAll();
            this.BotaoClasse = new Command<String>(OnPropertyChangedAsync);
        }
    }
}
