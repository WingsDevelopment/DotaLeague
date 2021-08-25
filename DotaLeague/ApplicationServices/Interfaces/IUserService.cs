using ApplicationServices.ApplicationDTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationServices.Interfaces
{
    public interface IUserService
    {
        public Task<UserDTO> CreateUser(string email);
        public Task<UserDTO> GetUserById(int id);
        public Task<UserDTO> GetUserByEmail(int email);

        /// <summary>
        /// MMR descending
        /// </summary>
        /// <returns></returns>
        public Task<IEnumerable<UserDTO>> GetScoreBoard(int leagueId);


    }
}
