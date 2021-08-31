using Domain.Entities;
using DotaLeague.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ApplicationServices.ApplicationDTOs
{
    public class PlayerDTO
    {
        public int Id { get; set; }
        /// <summary>
        /// User's email
        /// </summary>
        public string Email { get; set; }
        public string DisplayName { get; set; }
        public DateTime RegisteredAt { get; set; }

        public int NumberOfMatches { get; set; }
        public float Winrate { get; set; }
        public int VouchedLeague { get; set; }
        public string SteamID { get; set; }
        public DateTime TimeOutDateTime { get; set; }
        public bool IsBanned { get; set; }
        public List<ReportDTO> Reports { get; set; }
        public int Likes { get; set; }
        public int Dislikes { get; set; }
        public int Pos1PriorityValue { get; set; }
        public int Pos2PriorityValue { get; set; }
        public int Pos3PriorityValue { get; set; }
        public int Pos4PriorityValue { get; set; }
        public int Pos5PriorityValue { get; set; }

        public PlayerDTO(Player player)
        {
            Id = player.Id;
            Email = player.Email;
            RegisteredAt = player.RegisteredAt;
            SteamID = player.SteamID;
            TimeOutDateTime = player.TimeOutDateTime;
            Likes = player.Likes;
            Dislikes = player.Dislikes;

            NumberOfMatches = player.NumberOfMatches;
            Winrate = player.Winrate;

            Winrate = player.Winrate;

            VouchedLeague = player.VouchedLeague;
            Reports = player.Reports?.ToReportDTOs()?.ToList();
        }
    }
}
