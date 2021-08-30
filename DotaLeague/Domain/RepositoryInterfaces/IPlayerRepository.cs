using DotaLeague.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Domain.RepositoryInterfaces
{
    public interface IPlayerRepository : IBaseRepository<Player>
    {
        public Task<Player> GetPlayerByEmail(string email);
    }
}
