using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Domain.RepositoryInterfaces
{
    public interface IQueueRepository : IBaseRepository<PlayerShort>
    {
        public Task<PlayerShort> GetPlayerByEmail(string email);
        public Task<int> GetQueueCount(int leagueId);
        public Task<List<PlayerShort>> GetAll(int take, int leagueId);
        public Task RemoveAll(IEnumerable<PlayerShort> playerShorts);
    }
}
