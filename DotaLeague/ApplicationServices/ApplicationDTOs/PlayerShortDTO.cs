using Domain.Entities;
using DotaLeague.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationServices.ApplicationDTOs
{
    public class PlayerShortDTO
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public int WinRate { get; set; }
        public int MMR { get; set; }

        public PlayerShortDTO(Player player)
        {
            Id = player.Id;
            Email = player.Email;
            WinRate = player.Winrate;
            MMR = player.MMR;
        }

        public PlayerShortDTO(PlayerShort player)
        {
            Id = player.Id;
            Email = player.Email;
            WinRate = player.WinRate;
            MMR = player.MMR;
        }
    }
}
