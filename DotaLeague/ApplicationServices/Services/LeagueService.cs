using ApplicationServices.ApplicationDTOs;
using ApplicationServices.Interfaces;
using Domain.Entities;
using Domain.RepositoryInterfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Utils.Exceptions;

namespace ApplicationServices.Services
{
    public class LeagueService : ILeagueService
    {
        private readonly IUnitOfWork _unitOfWork;

        public LeagueService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<LeagueDTO> GetLeagueById(int leagueId)
        {
            var league = await _unitOfWork.LeagueRepository.GetById(leagueId);

            return new LeagueDTO(league);
        }
        public async Task<LeagueWithQueueDTO> GetLeagueWithQueueById(int leagueId)
        {
            var league = await _unitOfWork.LeagueRepository.GetById(leagueId);
            if (league == null) throw new LeagueServiceException("League not found!");
            var players = await _unitOfWork.QueueRepository.GetAll(leagueId);

            return new LeagueWithQueueDTO(league, players);
        }

        public async Task<ICollection<LeagueDTO>> GetAll()
        {
            var leagues = await _unitOfWork.LeagueRepository.GetAll();

            return leagues.ToLeagueDTOs();
        }
        public async Task<LeagueDTO> CreateLeague(string name,
            DateTime startDateTime,
            DateTime endDateTime)
        {
            var league = new League(name, startDateTime, endDateTime);

            await _unitOfWork.LeagueRepository.Insert(league);
            await _unitOfWork.SaveChangesAsync();

            return new LeagueDTO(league);
        }
        public async Task<LeagueDTO> UpdateLeague(int id,
            string name,
            DateTime startDateTime,
            DateTime endDateTime)
        {
            var league = await _unitOfWork.LeagueRepository.GetById(id);
            if (league == null) throw new LeagueServiceException("League not found!");

            league.SetName(name);
            league.SetStartDateTime(startDateTime);
            league.SetEndDateTime(endDateTime);

            await _unitOfWork.LeagueRepository.Update(league);
            await _unitOfWork.SaveChangesAsync();

            return new LeagueDTO(league);
        }

        public async Task<PlayerDTO> VouchPlayer(int playerId, int leagueId)
        {
            var league = await _unitOfWork.LeagueRepository.GetById(leagueId);
            if (league == null) throw new LeagueServiceException("League not found!");

            var player = await _unitOfWork.PlayerRepository.GetById(playerId);
            if (player == null) throw new LeagueServiceException("Player not found!");

            player.SetVouchedLeagueId(league.Id);

            await _unitOfWork.PlayerRepository.Update(player);
            await _unitOfWork.SaveChangesAsync();

            return new PlayerDTO(player);
        }
        public async Task<PlayerDTO> UnVouchPlayer(int playerId, int leagueId)
        {
            var league = await _unitOfWork.LeagueRepository.GetById(leagueId);
            if (league == null) throw new LeagueServiceException("League not found!");

            var player = await _unitOfWork.PlayerRepository.GetById(playerId);
            if (player == null) throw new LeagueServiceException("Player not found!");

            //todo: make it nullable
            player.SetVouchedLeagueId(-1);

            await _unitOfWork.PlayerRepository.Update(player);
            await _unitOfWork.SaveChangesAsync();

            return new PlayerDTO(player);
        }
        public async Task<LeagueDTO> DeleteLeague(int leagueId)
        {
            var league = await _unitOfWork.LeagueRepository.GetById(leagueId);
            if (league == null) throw new LeagueServiceException("League not found!");

            league.SetIsDeleted(true);

            await _unitOfWork.LeagueRepository.Update(league);
            await _unitOfWork.SaveChangesAsync();

            return new LeagueDTO(league);
        }

    }
}
