using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace GuideForDDOn.Model
{
    public class Job
    {
        [PrimaryKey, AutoIncrement]
        public int id_Job { get; set; }
        public string Nome { get; private set; }
        public string Tipo { get; private set; }

        public Job() { }
        public String Selecao()
        {
            return id_Job + "";
        }
    }
}
