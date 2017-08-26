using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace wsDDon.Models
{
    public class Monstro
    {
        [Key]
        public int id_Monstro { get; set; }
        [Required(ErrorMessage = "O categoria é obrigatorio")]
        public int categoria { get; set; }
        [Required(ErrorMessage = "O categoria é obrigatorio")]
        public string nome { get; set; }
        [Required(ErrorMessage = "O categoria é obrigatorio")]
        public string apelido { get; set; }
        [Required(ErrorMessage = "O categoria é obrigatorio")]
        public int Id_Especie { get; set; }
        public virtual Especie Especie { get; set; }

        public string pontoFraco { get; set; }

        public string obs { get; set; }

        public string elementoFraco { get; set; }

        public string drop { get; set; }

        public string localizacao { get; set; }

        [Required(ErrorMessage = "O categoria é obrigatorio")]
        public int idiomaid { get; set; }
    }
}