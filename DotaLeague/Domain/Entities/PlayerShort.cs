using DotaLeague.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class PlayerShort
    {
        public int Id { get; set; }
        public string DisplayName { get; set; }
        public string Email { get; set; }
        public float WinRate { get; set; }
        public int MMR { get; set; }
        public int NumberOfMatches { get; set; }
        public string SteamID { get; set; }

        public int Pos1PriorityValue { get; set; }
        public int Pos2PriorityValue { get; set; }
        public int Pos3PriorityValue { get; set; }
        public int Pos4PriorityValue { get; set; }
        public int Pos5PriorityValue { get; set; }
        public PlayerShort()
        {

        }
        public PlayerShort(string email, 
            float winrate, 
            int mmr, 
            string steamID,
            int numberOfMatches)
        {
            Email = email;
            WinRate = winrate;
            MMR = mmr;
            SteamID = steamID;
            NumberOfMatches = numberOfMatches;
        }

        public PlayerShort(Player player)
        {
            Email = player.Email;
            WinRate = player.Winrate;
            MMR = player.MMR;
            SteamID = player.SteamID;
            NumberOfMatches = player.NumberOfMatches;

            Pos1PriorityValue = player.Pos1PriorityValue;
            Pos2PriorityValue = player.Pos2PriorityValue;
            Pos3PriorityValue = player.Pos3PriorityValue;
            Pos4PriorityValue = player.Pos4PriorityValue;
            Pos5PriorityValue = player.Pos5PriorityValue;
        }
    }
}
