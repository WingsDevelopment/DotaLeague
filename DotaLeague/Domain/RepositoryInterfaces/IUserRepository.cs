using DotaLeague.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Domain.RepositoryInterfaces
{
    public interface IUserRepository : IBaseRepository<Player>
    {
        public Task<Player> GetUserByEmail(string email);
    }
}
