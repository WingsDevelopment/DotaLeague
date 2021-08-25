using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotaLeague.Domain.Entities
{
    public class User
    {
        public string Id { get; set; }
        /// <summary>
        /// User's email
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// User's password hash
        /// </summary>
        public string PasswordHash { get; set; }
        public List<string> Roles { get; set; }
        public DateTime RegisteredAt { get; set; }

        public List<League> VouchedLeagues { get; set; }
        public List<Report> Reports { get; set; }
        public DateTime TimeOutDateTime { get; set; }
        public string SteamID { get; set; }
        public bool IsBanned { get; set; }
        public int Likes { get; set; }
        public int Dislikes { get; set; }

        public User()
        {
            RegisteredAt = DateTime.Now;
        }
    }
}
