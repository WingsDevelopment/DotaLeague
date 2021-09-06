using DotaLeague.Domain.Entities;
using DotaLeague.Domain.Entities.MatchEntities;
using DotaLeague.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities.MatchEntities
{
    public class MatchPlayerData
    {
        public int Id { get; private set; }
        public int PlayerId { get; private set; }
        public int MatchId { get; private set; }
        public Player Player { get; private set; }
        public TeamName Team { get; private set; }
        public Match Match { get; private set; }

        public MatchPlayerData()
        {

        }
    }
}
