using Domain.Entities;
using DotaLeague.Domain.Entities;
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
