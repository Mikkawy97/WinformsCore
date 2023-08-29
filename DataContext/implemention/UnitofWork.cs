using DataContext.Context;
using RepositoryLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DataContext.implemention
{
    public class UnitofWork : IUnitofwork
    {
        private readonly CompanyContext _companyContext;
        public UnitofWork(CompanyContext context)
        {
            _companyContext = context;
            UserRepo=new UserRepository(_companyContext);   
            AdminRepo = new AdminRepository(_companyContext);
            CustomerRepo = new CustomerRepository(_companyContext); 
        }
        public IAdminRepo AdminRepo { get; private set; }

        public IUserRepository UserRepo { get; private set; }

        public ICustomerRepo CustomerRepo { get; private set; }

        public void Dispose()
        {
           _companyContext.Dispose();
        }

        public int save()
        {
            return _companyContext.SaveChanges();
        }
    }
}
