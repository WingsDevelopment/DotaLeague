using ApplicationServices.ApplicationDTOs;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotaLeague.Models.PlayerViewModels
{
    public class PlayerEditVM
    {
        public int Id { get; set; }
        public string DisplayName { get; set; }
        public int VouchedLeague { get; set; }
        public string SteamID { get; set; }
        public DateTime TimeOutDateTime { get; set; }
        public int Pos1PriorityValue { get; set; }
        public int Pos2PriorityValue { get; set; }
        public int Pos3PriorityValue { get; set; }
        public int Pos4PriorityValue { get; set; }
        public int Pos5PriorityValue { get; set; }
        public ICollection<LeagueDTO> LeagueDTOs { get; set; }
        public LeagueDTO VouchedLeagueDTO { get; set; }

        public PlayerEditVM()
        {

        }
        public PlayerEditVM(PlayerDTO player, ICollection<LeagueDTO> leagues)
        {
            Id = player.Id;
            DisplayName = player.DisplayName;
            VouchedLeague = player.VouchedLeague;
            SteamID = player.SteamID;
            TimeOutDateTime = player.TimeOutDateTime;

            Pos1PriorityValue = player.Pos1PriorityValue;
            Pos2PriorityValue = player.Pos2PriorityValue;
            Pos3PriorityValue = player.Pos3PriorityValue;
            Pos4PriorityValue = player.Pos4PriorityValue;
            Pos5PriorityValue = player.Pos5PriorityValue;

            LeagueDTOs = leagues;

            VouchedLeagueDTO = LeagueDTOs.Where(x => x.Id == VouchedLeague).SingleOrDefault();
        }

        public IEnumerable<SelectListItem> LeagueSelect
        {
            get
            {
                return LeagueDTOs?.Select(league => 
                    new SelectListItem { 
                        Value = league.Id.ToString(), 
                        Text = league.Name })
                    .OrderBy(item => item.Value);
            }
        }
    }
}
