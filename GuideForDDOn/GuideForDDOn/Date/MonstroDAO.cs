using GuideForDDOn.Model;
using SQLite;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace GuideForDDOn.Date
{
    public class MonstroDAO
    {
        SQLiteConnection conexao;

        public MonstroDAO(SQLiteConnection con)
        {
            this.conexao = con;
        }

        public Monstro GetMonstroExpecifico(string x)
        {
            try
            {
                Monstro OMonstro = conexao.Query<Monstro>("select * from Monstro where apelido = '"  + x + "'")[0];
                return OMonstro;
            }
            catch (ArgumentOutOfRangeException e)
            {
                throw new ExceptionNula();
            }
        }
        public ObservableCollection<Monstro> GetExpecifico(int x)
        {
            try
            {
                ObservableCollection<Monstro> OMonstro = new ObservableCollection<Monstro>(conexao.Query<Monstro>("select * from Monstro where id_Monstro = " + x));
                return OMonstro;
            }
            catch (ArgumentOutOfRangeException e)
            {
                throw new ExceptionNula();
            }
        }

        internal ObservableCollection<Monstro> GetOne(int x)
        {
            try
            {
                ObservableCollection<Monstro> OMonstro = new ObservableCollection<Monstro>(conexao.Query<Monstro>("select * from Monstro where categoria = " + x));
                return OMonstro;
            }
            catch (Exception e)
            {
                throw new ExceptionNula();
            }
        }

        internal ObservableCollection<Monstro> GetAllEspecie(int x)
        {
            try
            {
                ObservableCollection<Monstro> OMonstro = new ObservableCollection<Monstro>(conexao.Query<Monstro>("select * from Monstro where categoria = " + x + " group by especie order by id_Monstro"));
                return OMonstro;
            }
            catch (Exception e)
            {
                throw new ExceptionNula();
            }
        }

        internal ObservableCollection<Monstro> GetAllForEspecie(int x, string y)
        {
            ObservableCollection<Monstro> OMonstro = new ObservableCollection<Monstro>(conexao.Query<Monstro>("select * from Monstro where categoria = " + x + " and especie = '" + y + "' order by id_Monstro"));
            if (OMonstro[0].apelido == null)
            {
                throw new ExceptionNula();
            }
            return OMonstro;
        }
    }
}
