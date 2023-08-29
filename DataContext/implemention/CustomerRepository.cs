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
    public class CustomerRepository : GenricRepository<Customer>, ICustomerRepo
    {
        public CustomerRepository(CompanyContext context) : base(context)
        {
        }
    }
}
