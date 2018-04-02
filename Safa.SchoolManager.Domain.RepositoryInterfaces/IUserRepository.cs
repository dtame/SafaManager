using Safa.SchoolManager.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Safa.SchoolManager.Domain.RepositoryInterfaces
{
        public interface IUserRepository
        {
            bool Login(string email, string password);
            User GetUserBy(string email);

            bool Add(User aUser);
        }

}
