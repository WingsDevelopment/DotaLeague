using ApplicationServices.ApplicationDTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationServices.Interfaces
{
    public interface IPlayerService
    {
        public Task<PlayerDTO> CreateUser(string email);
        public Task<PlayerDTO> GetUserById(int id);
        public Task<PlayerDTO> GetUserByEmail(int email);

        /// <summary>
        /// MMR descending
        /// </summary>
        /// <returns></returns>
        public Task<IEnumerable<PlayerDTO>> GetScoreBoard(int leagueId);


    }
}
