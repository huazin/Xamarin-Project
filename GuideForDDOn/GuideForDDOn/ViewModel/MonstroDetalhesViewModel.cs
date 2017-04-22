using GuideForDDOn.Date;
using GuideForDDOn.Model;
using SQLite;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace GuideForDDOn.ViewModel 
{
    public class MonstroDetalhesViewModel
    {
        ContentPage page;
        private MonstroDAO dao;
        private SQLiteConnection con;
        private ObservableCollection<Monstro> listRef;

        public ObservableCollection<Monstro> ListRef
        {
            get
            {
                return listRef;
            }
            set
            {
                listRef = value;
            }
        }
        public MonstroDetalhesViewModel(SQLiteConnection Con, List<String> Nome,ContentPage Page)
        {
            this.con = Con;
            this.page = Page;
            try
            {
                this.dao = new MonstroDAO(con);
                int i = 0;
                listRef = new ObservableCollection<Monstro>();
                
                    foreach (var a in Nome)
                    {
                    try
                    {
                        listRef.Add(dao.GetMonstroExpecifico(Nome[i]));
                    }
                    catch (ExceptionNula e)
                    {
                        this.page.DisplayAlert("Erro", "Inimigo não encontrado, Por favor entra em contanto para correção", "OK");
                    }
                    i++;
                }
                

            }
            catch (ExceptionNula e)
            {
            }
        }
        public MonstroDetalhesViewModel(SQLiteConnection Con, int x)
        {
            this.con = Con;
            this.dao = new MonstroDAO(con);
            listRef = dao.GetOne(x);
        }
        public MonstroDetalhesViewModel(int x, SQLiteConnection Con)
        {
            this.con = Con;
            this.dao = new MonstroDAO(con);
            listRef = dao.GetExpecifico(x);
        }
    }
}
