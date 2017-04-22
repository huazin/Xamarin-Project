using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace GuideForDDOn.ViewModel
{
    class InfoJobViewModel
    {
        private string nome;
        SQLiteConnection con;

        public string Nome {
            get { return this.nome; }
            set{ this.nome = value; }
        }
        public InfoJobViewModel(SQLiteConnection Con,string Nome)
        {
            this.nome = Nome;
            this.con = Con;
        }
    }
}
