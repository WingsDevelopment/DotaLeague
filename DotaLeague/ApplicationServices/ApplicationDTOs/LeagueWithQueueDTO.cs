using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ApplicationServices.ApplicationDTOs
{
    public class LeagueWithQueueDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }
        public ICollection<PlayerShort> PlayersInQueue { get; set; }

        public LeagueWithQueueDTO(League league, ICollection<PlayerShort> playersInQueue)
        {
            Id = league.Id;
            Name = league.Name;
            StartDateTime = league.StartDateTime;
            EndDateTime = league.EndDateTime;
            PlayersInQueue = playersInQueue;
        }
    }
    public static class LeagueWithQueueDTOExtension
    {
        public static ICollection<LeagueDTO> ToLeagueWithQueueDTOs(this ICollection<League> leagues)
        {
            return leagues.Select(a => new LeagueDTO(a)).ToList();
        }
    }
}
