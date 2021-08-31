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

        public Task<PlayerShort> GetPlayerByEmail(string email)
        {
            var result = DbSet.Where(p => p.Email.ToLower().Equals(email.ToLower()));

            return result.SingleOrDefaultAsync();
        }
    }
}
