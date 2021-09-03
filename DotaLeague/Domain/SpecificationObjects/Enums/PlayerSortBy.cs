using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.SpecificationObjects.Enums
{
    public enum PlayerSortBy
    {
        Undefined = 0,

        MMRAscending = 1,
        MMRDescending = 2,

        WinrateAscending = 3,
        WinrateDescending = 4,

        LikesAscending = 5,
        LikesDescending = 6,

        DisLikesAscending = 7,
        DisLikesDescending = 8,

        TimeOutDateTimeAscending = 9,
        TimeOutDateTimeDescending = 10,

        RegisteredAtAscending = 11,
        RegisteredAtDescending = 12,

        NumberOfMatchesAscending = 13,
        NumberOfMatchesDescending = 14,
    }
}
