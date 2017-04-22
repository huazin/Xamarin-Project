using GuideForDDOn.Model;
using SQLite;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace GuideForDDOn.Date
{
    public class HabilidadeDAO
    {
        SQLiteConnection conexao;

        public ObservableCollection<Habilidades> GetHabiEx(int x)
        {
            //return new ObservableCollection<Habilidades>(conexao.Table<Habilidades>());
            return new ObservableCollection<Habilidades>(conexao.Query<Habilidades>("select * from Habilidades where id_Job = " + x));
        }
        public HabilidadeDAO(SQLiteConnection con)
        {
            this.conexao = con;
        }

        internal ObservableCollection<Habilidades> GetOne(int x)
        {
            return new ObservableCollection<Habilidades>(conexao.Query<Habilidades>("select * from Habilidades where id_Habilidade = " + x));
        }
    }
}
