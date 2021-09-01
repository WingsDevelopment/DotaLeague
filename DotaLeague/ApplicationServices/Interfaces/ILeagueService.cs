using ApplicationServices.ApplicationDTOs;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ApplicationServices.Interfaces
{
    public interface ILeagueService
    {
        Task<LeagueDTO> CreateLeague(string name, DateTime startDateTime, DateTime endDateTime);
        Task<LeagueDTO> DeleteLeague(int leagueId);
        Task<ICollection<LeagueDTO>> GetAll();
        Task<PlayerDTO> UnVouchPlayer(int playerId, int leagueId);
        Task<LeagueDTO> UpdateLeague(int id, string name, DateTime startDateTime, DateTime endDateTime);
        Task<PlayerDTO> VouchPlayer(int playerId, int leagueId);
        Task<LeagueDTO> GetLeagueById(int leagueId);
        Task<LeagueWithQueueDTO> GetLeagueWithQueueById(int leagueId);
    }
}
