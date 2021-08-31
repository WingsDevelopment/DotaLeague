using ApplicationServices.ApplicationDTOs;
using ApplicationServices.Interfaces;
using Domain.Entities;
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
        private readonly IMatchFactory _matchFactory;
        //todo premestiti u app settings
        private readonly int MaxQueueNumber = 10;

        public PlayerService(IUnitOfWork unitOfWork,
            IMatchFactory matchFactory)
        {
            _unitOfWork = unitOfWork;
            _matchFactory = matchFactory;
        }

        public async Task<IEnumerable<PlayerShortDTO>> GetPlayersInQueue(int leagueId)
        {
            var players = await _unitOfWork.QueueRepository.GetAll(MaxQueueNumber, leagueId);

            return players.ToPlayerShortDTOs();
        }

        public async Task<PlayerShortDTO> Queue(string email, int leagueId)
        {
            //todo: start transaction
            var player = await _unitOfWork.PlayerRepository.GetPlayerByEmail(email);
            if (player == null) throw new ArgumentException();

            //todo: dodati lige
            //var league = await _unitOfWork.LeagueRepository.GetById(leagueId);
            //if (league == null) throw new ArgumentException();

            //if (String.IsNullOrWhiteSpace(player.SteamID)) throw new InvalidSteamIDException();
            //if (player.VouchedLeague != league.Id) throw new NotVouchedException();

            //todo: smisliti kako voditi count i startovati match!
            var playerShort = new PlayerShort(player);

            var count = await _unitOfWork.QueueRepository.GetQueueCount();
            if (count >= MaxQueueNumber - 1)
            {
                var players = await _unitOfWork.QueueRepository.GetAll(MaxQueueNumber);
                if (players.Count == MaxQueueNumber - 1) players.Add(playerShort);
                //else

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

        /// <summary>
        /// must throw PlayerAlreadyExistException if player exist
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public async Task<PlayerDTO> CreatePlayer(string email)
        {
            var data = await _unitOfWork.PlayerRepository.GetPlayerByEmail(email);
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
