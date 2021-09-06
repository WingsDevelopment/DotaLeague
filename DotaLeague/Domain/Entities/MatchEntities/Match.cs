using Domain.Entities;
using Domain.Entities.MatchEntities;
using DotaLeague.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotaLeague.Domain.Entities.MatchEntities
{
    public class Match
    {
        public int Id { get; private set; }
        /// <summary>
        /// How much mmr will players win and lose
        /// </summary>
        public int MMR { get; private set; }
        /// <summary>
        /// Winning team
        /// </summary>
        public TeamName Winner { get; private set; }
        /// <summary>
        /// Match state
        /// </summary>
        public MatchState MatchState { get; private set; }
        /// <summary>
        /// Match data
        /// </summary>
        public List<MatchPlayerData> MatchPlayerData { get; private set; }

        public Match()
        {

        }
    }
}
