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
        /// <summary>
        /// User's password hash
        /// </summary>
        public string PasswordHash { get; set; }
        public DateTime RegisteredAt { get; set; }

        public List<LeagueDTO> VouchedLeagues { get; set; }
        public string SteamID { get; set; }
        public DateTime TimeOutDateTime { get; set; }
        public bool IsBanned { get; set; }
        public List<ReportDTO> Reports { get; set; }
        public int Likes { get; set; }
        public int Dislikes { get; set; }

        public PlayerDTO(Player user)
        {
            Id = user.Id;
            Email = user.Email;
            PasswordHash = user.PasswordHash;
            RegisteredAt = user.RegisteredAt;
            SteamID = user.SteamID;
            TimeOutDateTime = user.TimeOutDateTime;
            Likes = user.Likes;
            Dislikes = user.Dislikes;

            VouchedLeagues = user.VouchedLeagues?.ToLeagueDTOs()?.ToList();
            Reports = user.Reports?.ToReportDTOs()?.ToList();
        }
    }
}
