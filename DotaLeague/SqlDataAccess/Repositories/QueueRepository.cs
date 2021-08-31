using Domain.Entities;
using Domain.RepositoryInterfaces;
using Microsoft.EntityFrameworkCore;
using SqlDataAccess.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlDataAccess.Repositories
{
    public class QueueRepository : EfCoreBaseRepository<PlayerShort>, IQueueRepository
    {
        public QueueRepository(SqlDotaLeagueContext context) : base(context)
        {

        }
        public async Task<int> GetQueueCount(int leagueId)
        {
            var result = await DbSet.Where(p => p.VouchedLeague == leagueId).CountAsync();

            return result;
        }

        public Task<List<PlayerShort>> GetAll(int take, int leagueId)
        {
            var result = DbSet.Where(p => p.VouchedLeague == leagueId).Take(take);

            return result.ToListAsync();
        }
        public Task RemoveAll(IEnumerable<PlayerShort> playerShorts)
        {
            DbSet.RemoveRange(playerShorts);

            return Task.CompletedTask;
        }

        public Task<PlayerShort> GetPlayerByEmail(string email)
        {
            var result = DbSet.Where(p => p.Email.ToLower().Equals(email.ToLower()));

            return result.SingleOrDefaultAsync();
        }

    }
}
