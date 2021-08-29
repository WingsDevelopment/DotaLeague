using ApplicationServices.ApplicationDTOs;
using ApplicationServices.Interfaces;
using Domain.RepositoryInterfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationServices
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public Task<UserDTO> CreateUser(string email)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<UserDTO>> GetScoreBoard(int leagueId)
        {
            throw new NotImplementedException();
        }

        public Task<UserDTO> GetUserByEmail(int email)
        {
            throw new NotImplementedException();
        }

        public Task<UserDTO> GetUserById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
