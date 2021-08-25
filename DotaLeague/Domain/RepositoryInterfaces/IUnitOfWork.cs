using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.RepositoryInterfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IReportRepository ReportRepository { get; }
        IUserRepository UserRepository { get; }
        IMatchRepository MatchRepository { get; }
    }
}
