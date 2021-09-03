using ApplicationServices.ApplicationDTOs;
using ApplicationServices.Interfaces;
using Domain.Entities;
using Domain.RepositoryInterfaces;
using Domain.SpecificationObjects.Enums;
using DotaLeague.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Utils.Exceptions;

namespace ApplicationServices.Services
{
    public class PlayerService : IPlayerService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMatchFactory _matchFactory;
        //todo premestiti u app settings
        private readonly int MaxQueueNumberPerLeague = 10;

        public PlayerService(IUnitOfWork unitOfWork,
            IMatchFactory matchFactory)
        {
            _unitOfWork = unitOfWork;
            _matchFactory = matchFactory;
        }

        public async Task<PlayerShortDTO> Queue(string email, int leagueId)
        {
            //todo: start transaction
            var player = await _unitOfWork.PlayerRepository.GetPlayerByEmail(email);
            if (player == null) throw new ArgumentException();

            var queueData = await _unitOfWork.QueueRepository.GetByPlayerId(player.Id);
            if (queueData != null)
            {
                throw new PlayerServiceException("Player is already in queue!");
            }

            var league = await _unitOfWork.LeagueRepository.GetById(leagueId);
            if (league == null) throw new ArgumentException("Invalid league id");

            //if (String.IsNullOrWhiteSpace(player.SteamID)) throw new InvalidSteamIDException();
            if (player.VouchedLeague != league.Id) throw new NotVouchedException("You are not vouched for this league!");

            var playerShort = new PlayerShort(player);

            var count = await _unitOfWork.QueueRepository.GetQueueCount(leagueId);
            if (count >= MaxQueueNumberPerLeague - 1)
            {
                var players = await _unitOfWork.QueueRepository.GetAll(leagueId);
                if (players.Count == MaxQueueNumberPerLeague - 1) players.Add(playerShort);
                //todo: else?

                var match = _matchFactory.InstantiateMatch(players);

                await _unitOfWork.QueueRepository.RemoveAll(players);
                await _unitOfWork.MatchRepository.Insert(match);
                await _unitOfWork.SaveChangesAsync();
            }
            else
            {
                await _unitOfWork.QueueRepository.Insert(playerShort);
                await _unitOfWork.SaveChangesAsync();
            }
            return new PlayerShortDTO(playerShort);
        }

        public async Task<PlayerShortDTO> LeaveQueue(string email, int leagueId)
        {
            var player = await _unitOfWork.PlayerRepository.GetPlayerByEmail(email);
            if (player == null) throw new ArgumentException("Invalid email.");

            var league = await _unitOfWork.LeagueRepository.GetById(leagueId);
            if (league == null) throw new ArgumentException("Invalid league id");
            if (player.VouchedLeague != league.Id) throw new NotVouchedException("You are not vouched for this league!");

            var queueData = await _unitOfWork.QueueRepository.GetByPlayerId(player.Id);
            if (queueData != null)
            {
                await _unitOfWork.QueueRepository.Delete(queueData);
                await _unitOfWork.SaveChangesAsync();
            }
            else
            {
                throw new PlayerServiceException("Player is not in queue!");
            }

            return new PlayerShortDTO(queueData);
        }

        /// <summary>
        /// must throw PlayerAlreadyExistException if player exist
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public async Task<PlayerDTO> CreatePlayer(string email)
        {
            var data = await _unitOfWork.PlayerRepository.GetPlayerByEmail(email);
            if (data != null) throw new PlayerAlreadyExistException("Player already exist");

            var player = new Player(email);

            await _unitOfWork.PlayerRepository.Insert(player);
            await _unitOfWork.SaveChangesAsync();
            return new PlayerDTO(player);
        }

        public Task<IEnumerable<PlayerDTO>> GetScoreBoard(int leagueId)
        {
            throw new NotImplementedException();
        }

        public async Task<PlayerDTO> GetPlayerByEmail(string email)
        {
            var player = await _unitOfWork.PlayerRepository.GetPlayerByEmail(email);
            if (player == null) throw new ArgumentException("Player not found!");

            return new PlayerDTO(player);
        }

        public async Task<ICollection<PlayerDTO>> GetByFilters(int? byId, 
            string byDisplayName, string byEmail, string bySteamID, 
            DateTime? registratedFrom, DateTime? registratedTo, 
            int? mMRFrom, int? mMRTo, PlayerSortBy playerSortBy)
        {
            var players = await _unitOfWork.PlayerRepository.GetByFilters(
                    byId,
                    byDisplayName,
                    byEmail,
                    bySteamID,
                    registratedFrom,
                    registratedTo,
                    mMRFrom,
                    mMRTo,
                    playerSortBy
                );

            return players.ToPlayerDTOs();
        }

        public async Task<PlayerDTO> UpdatePlayer(int id, string displayName, string steamID, 
            DateTime timeOutDateTime, int vouchedLeague, 
            int pos1PriorityValue, int pos2PriorityValue, 
            int pos3PriorityValue, int pos4PriorityValue, int pos5PriorityValue)
        {
            var player = await _unitOfWork.PlayerRepository.GetById(id);
            if (player == null) throw new ArgumentException("Player not found!");

            var league = await _unitOfWork.LeagueRepository.GetById(vouchedLeague);
            if (league == null) throw new LeagueServiceException("League not found!");

            //todo: check if display name already exist
            player.SetDisplayName(displayName);
            //todo: check if Steam ID already exist
            player.SetSteamID(steamID);
            //todo: set max value?
            player.SetTimeOutDateTime(timeOutDateTime);
            player.SetVouchedLeagueId(vouchedLeague);
            //todo: make sure that its distinct
            player.SetPriorityValues(pos1PriorityValue,
                pos2PriorityValue,
                pos3PriorityValue,
                pos4PriorityValue,
                pos5PriorityValue);

            await _unitOfWork.PlayerRepository.Update(player);
            await _unitOfWork.SaveChangesAsync();

            return new PlayerDTO(player);
        }
    }
}
