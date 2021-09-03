using Domain.SpecificationObjects.Enums;
using DotaLeague.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Domain.RepositoryInterfaces
{
    public interface IPlayerRepository : IBaseRepository<Player>
    {
        public Task<Player> GetPlayerByEmail(string email);
        Task<ICollection<Player>> GetByFilters(int? byId, 
            string byDisplayName, string byEmail, string bySteamID, 
            DateTime? registratedFrom, DateTime? registratedTo, 
            int? mMRFrom, int? mMRTo, PlayerSortBy playerSortBy, int? skip = 0, int? take = null);
    }
}
