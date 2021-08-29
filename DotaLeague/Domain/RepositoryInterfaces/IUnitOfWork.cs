using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Domain.RepositoryInterfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IReportRepository ReportRepository { get; }
        IUserRepository PlayerRepository { get; }
        IMatchRepository MatchRepository { get; }
        Task SaveChangesAsync();
    }
}
