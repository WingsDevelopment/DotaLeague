using DotaLeague.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Domain.RepositoryInterfaces
{
    public interface IReportRepository : IBaseRepository<Report>
    {
        //Concrete methods
        public Task<IEnumerable<Report>> GetReportsByUser(string userId);
    }
}
