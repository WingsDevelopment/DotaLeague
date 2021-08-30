using Domain.Entities;
using Domain.RepositoryInterfaces;
using SqlDataAccess.Contexts;
using System;
using System.Collections.Generic;
using System.Text;

namespace SqlDataAccess.Repositories
{
    public class LeagueRepository : EfCoreBaseRepository<League>, ILeagueRepository
    {
        public LeagueRepository(SqlDotaLeagueContext context) : base(context)
        {

        }
    }
}
