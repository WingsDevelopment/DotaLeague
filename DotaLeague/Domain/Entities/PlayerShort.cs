using DotaLeague.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class PlayerShort
    {
        public int Id { get; private set; }
        public int PlayerId { get; private set; }
        public string DisplayName { get; private set; }
        public string Email { get; private set; }
        public float WinRate { get; private set; }
        public int MMR { get; private set; }
        public int NumberOfMatches { get; private set; }
        public string SteamID { get; private set; }
        public int VouchedLeague { get; private set; }

        public int Pos1PriorityValue { get; private set; }
        public int Pos2PriorityValue { get; private set; }
        public int Pos3PriorityValue { get; private set; }
        public int Pos4PriorityValue { get; private set; }
        public int Pos5PriorityValue { get; private set; }
        public PlayerShort()
        {

        }
        public PlayerShort(string email, 
            float winrate, 
            int mmr, 
            string steamID,
            int vouchedLeague,
            int numberOfMatches)
        {
            Email = email;
            DisplayName = email;
            WinRate = winrate;
            MMR = mmr;
            SteamID = steamID;
            VouchedLeague = vouchedLeague;
            NumberOfMatches = numberOfMatches;
        }

        public PlayerShort(Player player)
        {
            PlayerId = player.Id;
            Email = player.Email;
            WinRate = player.Winrate;
            MMR = player.MMR;
            SteamID = player.SteamID;
            NumberOfMatches = player.NumberOfMatches;
            VouchedLeague = player.VouchedLeague;
            DisplayName = player.DisplayName;

            Pos1PriorityValue = player.Pos1PriorityValue;
            Pos2PriorityValue = player.Pos2PriorityValue;
            Pos3PriorityValue = player.Pos3PriorityValue;
            Pos4PriorityValue = player.Pos4PriorityValue;
            Pos5PriorityValue = player.Pos5PriorityValue;
        }
    }
}
