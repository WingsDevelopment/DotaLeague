using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Domain.RepositoryInterfaces
{
    public interface ILeagueRepository : IBaseRepository<League>
    {
        public Task<List<League>> GetAll();
    }
}
