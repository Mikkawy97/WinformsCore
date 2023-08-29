using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer
{
    public interface IGenricRepo<T> where T : class

    {

        T GetbyId(int id);

        T Add(T item);
        public User Login(string username, string password);    
    }
}
