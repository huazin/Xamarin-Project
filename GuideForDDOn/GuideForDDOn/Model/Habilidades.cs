using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace GuideForDDOn.Model
{
    public class Habilidades
    {
        [PrimaryKey, AutoIncrement]
        public int id_Habilidade { get; set; }
        public int id_Job { get; set; }
        public String nome { get; set; }
        public String descricao { get; set; }
        public String nivel { get; set; }
        public int nivelForSix { get; set; }
        public String obs { get; set; }
        public String addUp { get; set; }
        public String add6 { get; set; }

        public String monster5 { get; set; }
        public String monster6 { get; set; }
        public String monster7 { get; set; }
        public String monster8 { get; set; }
        public String monster9 { get; set; }

        public Habilidades() { }
        /*public Habilidades(int idh, int idc, string Nome,String Descricao, String Nivel,int NivelForSix,String Obs, String AddUp, String Add6, String Monster5, String Monster6, String Monster7, String Monster8, String Monster9)
        {
            this.id_Habilidade = idh;
            this.id_Classe = idc;
            this.nome = Nome;
            this.descricao = Descricao;
            this.nivel = Nivel;
            this.addUp = AddUp;
            this.add6 = Add6;
            this.nivelForSix = NivelForSix;
            this.obs = Obs;
            this.monster5 = Monster5;
            this.monster5 = Monster6;
            this.monster5 = Monster7;
            this.monster5 = Monster8;
            this.monster5 = Monster9;
        }*/

        public String Selecao()
        {
            return id_Habilidade + "";
        }
    }
}
