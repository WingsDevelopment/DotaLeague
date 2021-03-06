using Domain.RepositoryInterfaces;
using Microsoft.EntityFrameworkCore;
using SqlDataAccess.Contexts;
using SqlDataAccess.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SqlDataAccess
{
    public class EfCoreUnitOfWork : IUnitOfWork
    {
        private readonly SqlDotaLeagueContext Context;

        private IReportRepository _reportRepository;
        private IPlayerRepository _userRepository;
        private IMatchRepository _matchRepository;
        private ILeagueRepository _leagueRepository;
        private IQueueRepository _queueRepository;

        public IReportRepository ReportRepository =>
            _reportRepository ??
            (_reportRepository = new ReportRepository(Context));

        public IPlayerRepository PlayerRepository =>
            _userRepository ??
            (_userRepository = new PlayerRepository(Context));

        public IMatchRepository MatchRepository =>
            _matchRepository ??
            (_matchRepository = new MatchRepository(Context));

        public ILeagueRepository LeagueRepository =>
            _leagueRepository ??
            (_leagueRepository = new LeagueRepository(Context));
        public IQueueRepository QueueRepository =>
            _queueRepository ??
            (_queueRepository = new QueueRepository(Context));

        public EfCoreUnitOfWork(SqlDotaLeagueContext context)
        {
            Context = context;
        }

        public async Task SaveChangesAsync()
        {
            try
            {
                await Context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException duce)
            {
                throw duce;
            }
            catch (DbUpdateException due)
            {
                throw due;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        private bool disposedValue = false;

        protected virtual void Dispose(bool disposing)
        {
            if (disposedValue)
            {
                return;
            }
            if (disposing)
            {
                Context.Dispose();
            }
            disposedValue = true;
        }

        public void Dispose()
        {
            Dispose(true);
        }
    }
}
