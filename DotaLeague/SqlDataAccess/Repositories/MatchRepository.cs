using Domain.RepositoryInterfaces;
using DotaLeague.Domain.Entities;
using SqlDataAccess.Contexts;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SqlDataAccess.Repositories
{
    public class MatchRepository : EfCoreBaseRepository<Match>, IMatchRepository
    {
        public MatchRepository(SqlDotaLeagueContext context) : base(context)
        {

        }
    }
}
