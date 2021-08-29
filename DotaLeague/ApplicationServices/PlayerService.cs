using ApplicationServices.ApplicationDTOs;
using ApplicationServices.Interfaces;
using Domain.RepositoryInterfaces;
using DotaLeague.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Utils.Exceptions;

namespace ApplicationServices
{
    public class PlayerService : IPlayerService
    {
        private readonly IUnitOfWork _unitOfWork;

        public PlayerService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        /// <summary>
        /// must throw PlayerAlreadyExistException if player exist
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public async Task<PlayerDTO> CreatePlayer(string email)
        {
            var data = await _unitOfWork.PlayerRepository.GetUserByEmail(email);
            if (data != null) throw new PlayerAlreadyExistException();

            var player = new Player(email);

            await _unitOfWork.PlayerRepository.Insert(player);
            await _unitOfWork.SaveChangesAsync();
            return new PlayerDTO(player);
        }

        public Task<IEnumerable<PlayerDTO>> GetScoreBoard(int leagueId)
        {
            throw new NotImplementedException();
        }

        public Task<PlayerDTO> GetPlayerByEmail(int email)
        {
            throw new NotImplementedException();
        }

        public Task<PlayerDTO> GetPlayerById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
