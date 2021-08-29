using Domain.RepositoryInterfaces;
using DotaLeague.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MockDataAccess
{
    //isto mozda mozes base repo imati implementaciju, zavisi od baze i organizacije koda
    public class ReportRepositoryMock : IReportRepository
    {
        public Task<Report> Insert(Report entity)
        {
            throw new NotImplementedException();
        }

        public Task<Report> Delete(string Id)
        {
            throw new NotImplementedException();
        }

        public Task<Report> GetById(string Id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Report>> GetReportsByUser(string UserId)
        {
            throw new NotImplementedException();
        }

        public Task<Report> Update(Report entity)
        {
            throw new NotImplementedException();
        }
        public void Dispose()
        {
            throw new NotImplementedException();
        }

        Task IBaseRepository<Report>.Insert(Report entity)
        {
            throw new NotImplementedException();
        }

        public Task<Report> GetById(object id)
        {
            throw new NotImplementedException();
        }

        Task<bool> IBaseRepository<Report>.Update(Report entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(Report entity)
        {
            throw new NotImplementedException();
        }
    }
}
