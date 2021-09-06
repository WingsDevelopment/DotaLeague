using Domain.Entities;
using DotaLeague.Domain.Entities.Match;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationServices.Interfaces
{
    public interface IMatchFactory
    {
        Match InstantiateMatch(IEnumerable<PlayerShort> players);
    }
}
