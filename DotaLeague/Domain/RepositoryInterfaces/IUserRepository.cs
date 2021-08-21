using DotaLeague.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Domain.RepositoryInterfaces
{
    public interface IUserRepository : IBaseRepository<User>
    {
        public Task<User> GetUserByEmail(string email);
    }
}
