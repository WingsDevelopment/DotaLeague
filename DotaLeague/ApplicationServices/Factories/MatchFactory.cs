using ApplicationServices.Interfaces;
using Domain.Entities;
using DotaLeague.Domain.Entities.MatchEntities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationServices.Factories
{
    public class MatchFactory : IMatchFactory
    {
        public MatchFactory()
        {

        }

        public Match InstantiateMatch(IEnumerable<PlayerShort> players)
        {
            //todo: stojce code

            return new Match();
        }
    }
}
