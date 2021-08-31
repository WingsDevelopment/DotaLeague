using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotaLeague.Domain.Entities
{
    public class Player
    {
        public int Id { get; set; }
        /// <summary>
        /// User's email
        /// </summary>
        public string Email { get; set; }
        public int MMR { get; set; }
        public int Winrate { get; set; }
        public string SteamID { get; set; }
        public DateTime RegisteredAt { get; set; }
        public int VouchedLeague { get; set; }
        public int Likes { get; set; }
        public int Dislikes { get; set; }
        public bool IsBanned { get; set; }
        public DateTime TimeOutDateTime { get; set; }
        public List<Report> Reports { get; set; }

        public Player()
        {
            RegisteredAt = DateTime.Now;
        }
        public Player(string email) : this()
        {
            //todo: implement seter za mail validaciju
            Email = email;
        }
    }
}
