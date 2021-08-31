using Domain.Entities;
using Domain.RepositoryInterfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SqlDataAccess.Repositories
{
    public class QueueRepository : EfCoreBaseRepository<PlayerShort>, IQueueRepository
    {
        public QueueRepository(SqlDotaLeagueContext context) : base(context)
        {

        }

        public Task<Player> GetPlayerByEmail(string email)
        {
            var result = DbSet.Where(p => p.Email.ToLower().Equals(email.ToLower()));

            return result.SingleOrDefaultAsync();
        }
    }
}
