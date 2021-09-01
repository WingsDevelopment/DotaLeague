using ApplicationServices.ApplicationDTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationServices.Interfaces
{
    public interface IPlayerService
    {
        public Task<PlayerDTO> CreatePlayer(string email);
        public Task<PlayerDTO> GetPlayerById(int id);
        public Task<PlayerDTO> GetPlayerByEmail(int email);

        /// <summary>
        /// MMR descending
        /// </summary>
        /// <returns></returns>
        public Task<IEnumerable<PlayerDTO>> GetScoreBoard(int leagueId);
        public Task<PlayerShortDTO> Queue(string email, int leagueId);
        Task<PlayerShortDTO> LeaveQueue(string email, int leagueId);
    }
}
