using DotaLeague.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class PlayerLeague
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int LeagueId { get; set; }
        public Player Player { get; set; }
        public League League { get; set; }
    }
}
