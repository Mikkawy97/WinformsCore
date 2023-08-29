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
    public class UserRepository : GenricRepository<User>, IUserRepository
    {
        public UserRepository(CompanyContext context) : base(context)
        {
        }

        public List<User> GetUsers()
        {
            throw new NotImplementedException();
        }
    }
}
