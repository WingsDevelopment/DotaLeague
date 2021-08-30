using Domain.RepositoryInterfaces;
using DotaLeague.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using SqlDataAccess.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlDataAccess.Repositories
{
    public class PlayerRepository : EfCoreBaseRepository<Player>, IPlayerRepository
    {
        public PlayerRepository(SqlDotaLeagueContext context) : base(context)
        {

        }

        public Task<Player> GetPlayerByEmail(string email)
        {
            var result = DbSet.Where(p => p.Email.ToLower().Equals(email.ToLower()));

            return result.SingleOrDefaultAsync();
        }
    }
}
