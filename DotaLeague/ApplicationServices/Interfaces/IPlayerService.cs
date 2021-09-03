using ApplicationServices.ApplicationDTOs;
using Domain.SpecificationObjects.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationServices.Interfaces
{
    public interface IPlayerService
    {
        public Task<PlayerDTO> CreatePlayer(string email);
        public Task<PlayerDTO> GetPlayerByEmail(string email);

        /// <summary>
        /// MMR descending
        /// </summary>
        /// <returns></returns>
        public Task<IEnumerable<PlayerDTO>> GetScoreBoard(int leagueId);
        public Task<PlayerShortDTO> Queue(string email, int leagueId);
        Task<PlayerShortDTO> LeaveQueue(string email, int leagueId);
        Task<ICollection<PlayerDTO>> GetByFilters(int? byId, 
            string byDisplayName, string byEmail, string bySteamID, 
            DateTime? registratedFrom, DateTime? registratedTo, 
            int? mMRFrom, int? mMRTo,
            PlayerSortBy playerSortBy);

        Task<PlayerDTO> UpdatePlayer(int id, string displayName, string steamID, 
            DateTime timeOutDateTime, int vouchedLeague, 
            int pos1PriorityValue, int pos2PriorityValue, int pos3PriorityValue, 
            int pos4PriorityValue, int pos5PriorityValue);
    }
}
