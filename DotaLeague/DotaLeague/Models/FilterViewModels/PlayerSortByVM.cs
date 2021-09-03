using Domain.SpecificationObjects.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotaLeague.Models.FilterViewModels
{
    public enum PlayerSortByVM
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

    public static class PlayerSortByExtension
    {
        public static PlayerSortBy ToPlayerSortBy(this PlayerSortByVM sortBy)
        {
            switch (sortBy)
            {
                case PlayerSortByVM.Undefined: 
                    return PlayerSortBy.Undefined;

                case PlayerSortByVM.MMRAscending:
                    return PlayerSortBy.MMRAscending;
                case PlayerSortByVM.MMRDescending:
                    return PlayerSortBy.MMRDescending;

                case PlayerSortByVM.WinrateAscending:
                    return PlayerSortBy.WinrateAscending;
                case PlayerSortByVM.WinrateDescending:
                    return PlayerSortBy.WinrateDescending;

                case PlayerSortByVM.LikesAscending:
                    return PlayerSortBy.LikesAscending;
                case PlayerSortByVM.LikesDescending:
                    return PlayerSortBy.LikesDescending;

                case PlayerSortByVM.DisLikesAscending:
                    return PlayerSortBy.DisLikesAscending;
                case PlayerSortByVM.DisLikesDescending:
                    return PlayerSortBy.DisLikesDescending;

                case PlayerSortByVM.TimeOutDateTimeAscending:
                    return PlayerSortBy.TimeOutDateTimeAscending;
                case PlayerSortByVM.TimeOutDateTimeDescending:
                    return PlayerSortBy.TimeOutDateTimeDescending;

                case PlayerSortByVM.RegisteredAtAscending:
                    return PlayerSortBy.RegisteredAtAscending;
                case PlayerSortByVM.RegisteredAtDescending:
                    return PlayerSortBy.RegisteredAtDescending;

                case PlayerSortByVM.NumberOfMatchesAscending:
                    return PlayerSortBy.NumberOfMatchesAscending;
                case PlayerSortByVM.NumberOfMatchesDescending:
                    return PlayerSortBy.NumberOfMatchesDescending;

                default:
                    throw new ArgumentException($"{nameof(PlayerSortByExtension)}: " +
                        $"Invalid player sort type");
            }
        }
    }
}
