using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotaLeague.Domain.Entities
{
    public class Player
    {
        public int Id { get; private set; }
        /// <summary>
        /// User's email
        /// </summary>
        public string Email { get; private set; }
        public string DisplayName { get; private set; }
        //queue
        public int MMR { get; private set; }
        public float Winrate { get; private set; }
        public int NumberOfMatches { get; private set; }
        public int Pos1PriorityValue { get; private set; }
        public int Pos2PriorityValue { get; private set; }
        public int Pos3PriorityValue { get; private set; }
        public int Pos4PriorityValue { get; private set; }
        public int Pos5PriorityValue { get; private set; }
        public string SteamID { get; private set; }
        public DateTime RegisteredAt { get; private set; }
        //todo rename to VouchedLeagueId
        public int VouchedLeague { get; private set; }
        //reports
        public int Likes { get; private set; }
        public int Dislikes { get; private set; }
        public bool IsBanned { get; private set; }
        public DateTime TimeOutDateTime { get; private set; }
        public List<Report> Reports { get; private set; }


        public Player()
        {
            RegisteredAt = DateTime.Now;
        }
        public Player(string email) : this()
        {
            //todo: implement seter za mail validaciju
            Email = email;
            DisplayName = email;
        }
        public void SetVouchedLeagueId(int id)
        {
            VouchedLeague = id;
        }
    }
}
