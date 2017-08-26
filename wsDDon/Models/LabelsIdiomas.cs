using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace wsDDon.Models
{
    public class LabelsIdiomas
    {
        public int IdiomaId { get; set; }
        //Home
        public string nome { get; set; }
        public string classes { get; set; }
        public string monstrospequenos { get; set; }
        public string monstrosgrandes { get; set; }
        public string opcao { get; set; }
        public string sobre { get; set; }
        public string news { get; set; }

        //Configuracao de Sistema
        public string idiomalabel { get; set; }
        public string botaoconfirmar { get; set; }

        //Sobre
        public string Devs { get; set; }
        public string Versao { get; set; }
        public string Links { get; set; }
        public string Equip { get; set; }

        //Monstros
        public string NomeMonstro { get; set; }
        public string apelido { get; set; }
        public string especie { get; set; }
        public string pontoFraco { get; set; }
        public string drop { get; set; }
        public string localizacao { get; set; }
        public string elementoFraco { get; set; }

        //Titulos
        public string TitleSobre { get; set; }
        public string TitleConfig { get; set; }
        public string TitleHome { get; set; }
        public string TitleMonstros { get; set; }
        public string TitleJob { get; set; }
        public string TitlePassiva { get; set; }
        public string TitleHabilidade { get; set; }
        public string detalhes { get; set; }//Titulo

        //Erros
        public string Error { get; set; }
        public string MonsterNotFound { get; set; }

        //Jobs 

        public string descricao { get; set; }

        //Skills
        public string nivel { get; set; }
        public string addup { get; set; }
        public string addsix { get; set; }
        public string apcost { get; set; }
        public string monstroparaupa { get; set; }
        public string monster5 { get; set; }
        public string monster6 { get; set; }
        public string monster7 { get; set; }
        public string monster8 { get; set; }
        public string monster9 { get; set; }
        public string notificacao { get; set; }
        public string monster4 { get; set; }
        public string skillok { get; set; }
        public string skillbo { get; set; }
    }
}