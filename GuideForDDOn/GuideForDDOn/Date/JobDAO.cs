using GuideForDDOn.Model;
using SQLite;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace GuideForDDOn.Date
{
    class JobDAO
    {
        SQLiteConnection conexao;
        private ObservableCollection<Job> lista;

        public ObservableCollection<Job> Lissta
        {
            get
            {
                if (lista == null)
                    lista = GetAll();
                return lista;
            }
            private set
            {
                this.lista = value;
            }
        }

        public ObservableCollection<Job> GetAll()
        {
            return new ObservableCollection<Job>(conexao.Table<Job>());
        }

        public JobDAO(SQLiteConnection con)
        {
            this.conexao = con;
        }
    }
}
