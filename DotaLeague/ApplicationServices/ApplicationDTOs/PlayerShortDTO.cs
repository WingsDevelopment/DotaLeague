using Domain.Entities;
using DotaLeague.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ApplicationServices.ApplicationDTOs
{
    public class PlayerShortDTO
    {
        public int Id { get; set; }
        public int PlayerId { get; set; }
        public string DisplayName { get; set; }
        public string Email { get; set; }
        public float WinRate { get; set; }
        public int MMR { get; set; }
        public string SteamID { get; set; }
        public int NumberOfMatches { get; set; }
        public int VouchedLeague { get; set; }

        public int Pos1PriorityValue { get; set; }
        public int Pos2PriorityValue { get; set; }
        public int Pos3PriorityValue { get; set; }
        public int Pos4PriorityValue { get; set; }
        public int Pos5PriorityValue { get; set; }

        public PlayerShortDTO(Player player)
        {
            PlayerId = player.Id;
            DisplayName = player.DisplayName;
            Email = player.Email;
            WinRate = player.Winrate;
            MMR = player.MMR;
            SteamID = player.SteamID;
            NumberOfMatches = player.NumberOfMatches;
            VouchedLeague = player.VouchedLeague;

            Pos1PriorityValue = player.Pos1PriorityValue;
            Pos2PriorityValue = player.Pos2PriorityValue;
            Pos3PriorityValue = player.Pos3PriorityValue;
            Pos4PriorityValue = player.Pos4PriorityValue;
            Pos5PriorityValue = player.Pos5PriorityValue;
        }

        public PlayerShortDTO(PlayerShort player)
        {
            Id = player.Id;
            PlayerId = player.PlayerId;
            DisplayName = player.DisplayName;
            Email = player.Email;
            WinRate = player.WinRate;
            MMR = player.MMR;
            SteamID = player.SteamID;
            VouchedLeague = player.VouchedLeague;

            Pos1PriorityValue = player.Pos1PriorityValue;
            Pos2PriorityValue = player.Pos2PriorityValue;
            Pos3PriorityValue = player.Pos3PriorityValue;
            Pos4PriorityValue = player.Pos4PriorityValue;
            Pos5PriorityValue = player.Pos5PriorityValue;
        }
    }
    public static class PlayerShortDTOExtension
    {
        public static ICollection<PlayerShortDTO> ToPlayerShortDTOs(
            this ICollection<PlayerShort> players)
        {
            return players.Select(x => new PlayerShortDTO(x)).ToList();
        }
    }
}
