using GuideForDDOn.Model;
using SQLite;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace GuideForDDOn.Date
{
    public class PassivasDAO
    {
        private SQLiteConnection conexao;
        public PassivasDAO(SQLiteConnection con)
        {
            this.conexao = con;
        }

        public ObservableCollection<Passivas> GetPassivaExpecifica(int x)
        {
            return new ObservableCollection<Passivas>(conexao.Query<Passivas>("select * from Passivas where id_Job = " + x));
        }
        internal ObservableCollection<Passivas> GetOne(int x)
        {
            return new ObservableCollection<Passivas>(conexao.Query<Passivas>("select * from Passivas where id_Passiva = " + x));
        }
    }
}
