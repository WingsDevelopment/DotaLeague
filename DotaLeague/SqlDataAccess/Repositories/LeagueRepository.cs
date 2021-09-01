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
    public class LeagueRepository : EfCoreBaseRepository<League>, ILeagueRepository
    {
        public LeagueRepository(SqlDotaLeagueContext context) : base(context)
        {

        }

        public Task<List<League>> GetAll()
        {
            var result = DbSet.Where(p => p.IsDeleted == false);

            return result.ToListAsync();
        }
    }
}
