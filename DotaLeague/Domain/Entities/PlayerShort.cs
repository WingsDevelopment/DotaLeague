using DotaLeague.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class PlayerShort
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public int WinRate { get; set; }
        public int MMR { get; set; }

        public PlayerShort()
        {

        }
        public PlayerShort(string email, int winrate, int mmr)
        {
            Email = email;
            WinRate = winrate;
            MMR = mmr;
        }

        public PlayerShort(Player player)
        {
            Email = player.Email;
            WinRate = player.Winrate;
            MMR = player.MMR;
        }
    }
}
