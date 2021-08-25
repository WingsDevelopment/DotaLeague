using Domain.RepositoryInterfaces;
using DotaLeague.Domain.Entities;
using SqlDataAccess.Contexts;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SqlDataAccess.Repositories
{
    public class ReportRepository : EfCoreBaseRepository<Report>, IReportRepository
    {
        public ReportRepository(SqlDotaLeagueContext context) : base(context)
        {

        }

        public Task<IEnumerable<Report>> GetReportsByUser(string userId)
        {
            throw new NotImplementedException();
        }
    }
}
