using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer
{
    public interface IUnitofwork : IDisposable
    {
        IAdminRepo AdminRepo { get; }
        IUserRepository UserRepo { get; }
        ICustomerRepo CustomerRepo { get; }
        int save();
    }
}
