using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Domain.RepositoryInterfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IReportRepository ReportRepository { get; }
        IPlayerRepository PlayerRepository { get; }
        IMatchRepository MatchRepository { get; }
        ILeagueRepository LeagueRepository { get; }
        IQueueRepository QueueRepository { get; }
        Task SaveChangesAsync();
    }
}
