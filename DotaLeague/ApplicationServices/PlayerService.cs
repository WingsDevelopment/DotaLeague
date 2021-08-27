using ApplicationServices.ApplicationDTOs;
using ApplicationServices.Interfaces;
using Domain.RepositoryInterfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationServices
{
    public class PlayerService : IPlayerService
    {
        private readonly IUserRepository _userRepository;

        public PlayerService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public Task<PlayerDTO> CreateUser(string email)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<PlayerDTO>> GetScoreBoard(int leagueId)
        {
            throw new NotImplementedException();
        }

        public Task<PlayerDTO> GetUserByEmail(int email)
        {
            throw new NotImplementedException();
        }

        public Task<PlayerDTO> GetUserById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
