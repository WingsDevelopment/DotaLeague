using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotaLeague.Domain.Enums
{
    public enum MatchState
    {
        Undefined = 0,
        Created = 1,
        Started = 2,
        Canceled = 3,
        Finished = 4
    }
}
