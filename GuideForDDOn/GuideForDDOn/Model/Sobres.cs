using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace GuideForDDOn.Model
{
    public class Sobres
    {
        [PrimaryKey]
        public int IdiomaId { get; set; }
        public string Devs { get; set; }
        public string Links { get; set; }
        public string Equip { get; set; }
    }
}
