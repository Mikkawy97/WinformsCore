using DataContext.Context;
using Model;
using RepositoryLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataContext.implemention
{
    public class GenricRepository<T> : IGenricRepo<T> where T : class
    {
        private readonly CompanyContext _companyContext;
        public GenricRepository(CompanyContext context)
        {
            _companyContext = context;
        }
        public T GetbyId(int id)
        {
            throw new NotImplementedException();
        }
        public T Add(T entity)
        {
            _companyContext.Set<T>().Add(entity);
            _companyContext.SaveChanges();
            return entity;
        }

        public User Login(string username, string password)
        {
            if (IsvalidUser(username, password)!=null)

            {

                return IsvalidUser(username, password);


            }
            else
            {
                return null;
            }
        }

        private User IsvalidUser(string userName, string password)

        {





            var q = from p in _companyContext.Users

                    where p.Name == userName

                    && p.Password == password

                    select p;



            if (q.Any())

            {

                return q.First<User>();

            }

            else

            {

                return null;

            }

        }
    }
}
