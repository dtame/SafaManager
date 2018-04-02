using Safa.SchoolManager.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Safa.SchoolManager.Domain.RepositoryInterfaces
{
    public interface IAccountRepository
    {
        bool AddAccount(Account account);
        bool UpdateAccount(Account account);
        Account GetAccountByEmail(string email);

    }
}
