using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ApplicationServices.ApplicationDTOs
{
    public class LeagueDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }

        public LeagueDTO(League league)
        {
            Id = league.Id;
            Name = league.Name;
            StartDateTime = league.StartDateTime;
            EndDateTime = league.EndDateTime;
        }
    }
    public static class LeagueDTOExtension
    {
        public static ICollection<LeagueDTO> ToLeagueDTOs(this ICollection<League> leagues)
        {
            return leagues.Select(a => new LeagueDTO(a)).ToList();
        }
    }
}
