using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wsDDon.Infra.Repository
{
    interface ICrud<T>
    {
        void Add(T Object);
        void Edit(T Objecto);
        void Remove(T Object);
        T FindById(int id);
        IEnumerable<T> List();
    }
}