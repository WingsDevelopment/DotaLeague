using Domain.RepositoryInterfaces;
using Domain.SpecificationObjects.Enums;
using DotaLeague.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using SqlDataAccess.Contexts;
using SqlDataAccess.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SqlDataAccess.Repositories
{
    public class PlayerRepository : EfCoreBaseRepository<Player>, IPlayerRepository
    {
        public PlayerRepository(SqlDotaLeagueContext context) : base(context)
        {

        }
        
        public async Task<ICollection<Player>> GetByFilters(int? byId, 
            string byDisplayName, string byEmail, string bySteamID, 
            DateTime? registratedFrom, DateTime? registratedTo, 
            int? mMRFrom, int? mMRTo, PlayerSortBy playerSortBy, int? skip = 0, int? take = null)
        {
            var filterExpression = BuildFilterExpression(
                    byId,
                    byDisplayName,
                    byEmail,
                    bySteamID,
                    registratedFrom,
                    registratedTo,
                    mMRFrom,
                    mMRTo);

            var orderBySettings = BuildOrderByExpression(playerSortBy);

            IQueryable<Player> query = DbSet.AsQueryable();

            if (filterExpression != null)
            {
                query = query.Where(filterExpression);
            }

            int? totalCount = (skip > 0 || take.HasValue)
                ? (int?)await query.CountAsync()
                : (int?)null;

            if (orderBySettings != null)
            {
                query = orderBySettings.IsAscending
                    ? query.OrderBy(orderBySettings.PropertySelector)
                    : query.OrderByDescending(orderBySettings.PropertySelector);
            }

            //foreach (Expression<Func<Player, object>> includeExpression in includes)
            //{
            //    query = query.Include(includeExpression);
            //}

            ICollection<Player> entities = await query.ToListAsync();

            if (!totalCount.HasValue)
            {
                totalCount = entities.Count;
            }

            return entities;
        }


        private OrderBySettings<Player> BuildOrderByExpression(PlayerSortBy playerSortBy)
        {
            OrderBySettings<Player> orderBySettings;
            Expression<Func<Player, object>> orderByExpression;

            bool isDescending = false;

            switch (playerSortBy)
            {
                case PlayerSortBy.Undefined:
                    return null;

                case PlayerSortBy.MMRAscending:
                    orderByExpression = _player => _player.MMR;
                    break;
                case PlayerSortBy.MMRDescending:
                    orderByExpression = _player => _player.MMR;
                    isDescending = true;
                    break;

                case PlayerSortBy.WinrateAscending:
                    orderByExpression = _player => _player.MMR;
                    break;
                case PlayerSortBy.WinrateDescending:
                    orderByExpression = _player => _player.MMR;
                    isDescending = true;
                    break;

                case PlayerSortBy.LikesAscending:
                    orderByExpression = _player => _player.MMR;
                    break;
                case PlayerSortBy.LikesDescending:
                    orderByExpression = _player => _player.MMR;
                    isDescending = true;
                    break;

                case PlayerSortBy.DisLikesAscending:
                    orderByExpression = _player => _player.MMR;
                    break;
                case PlayerSortBy.DisLikesDescending:
                    orderByExpression = _player => _player.MMR;
                    isDescending = true;
                    break;

                case PlayerSortBy.TimeOutDateTimeAscending:
                    orderByExpression = _player => _player.MMR;
                    break;
                case PlayerSortBy.TimeOutDateTimeDescending:
                    orderByExpression = _player => _player.MMR;
                    isDescending = true;
                    break;

                case PlayerSortBy.RegisteredAtAscending:
                    orderByExpression = _player => _player.MMR;
                    break;
                case PlayerSortBy.RegisteredAtDescending:
                    orderByExpression = _player => _player.MMR;
                    isDescending = true;
                    break;

                case PlayerSortBy.NumberOfMatchesAscending:
                    orderByExpression = _player => _player.MMR;
                    break;
                case PlayerSortBy.NumberOfMatchesDescending:
                    orderByExpression = _player => _player.MMR;
                    isDescending = true;
                    break;

                default:
                    throw new NotImplementedException($"{nameof(BuildOrderByExpression)}: " +
                        $"sort not implemented in repo");
            }

            orderBySettings = new OrderBySettings<Player>(orderByExpression, isDescending);

            return orderBySettings;
        }

        private Expression<Func<Player, bool>> BuildFilterExpression(
            int? byId,
            string byDisplayName, string byEmail, string bySteamID,
            DateTime? registratedFrom, DateTime? registratedTo,
            int? mMRFrom, int? mMRTo)
        {
            Expression<Func<Player, bool>> filterExpression = null;

            filterExpression = _player
                => (byId == null ||
                _player.Id == byId)
                &&
                (String.IsNullOrWhiteSpace(byDisplayName) ||
                _player.DisplayName.ToLower().Contains(byDisplayName.ToLower())
                &&
                (String.IsNullOrWhiteSpace(byEmail) ||
                _player.DisplayName.ToLower().Contains(byEmail.ToLower()))
                &&
                (String.IsNullOrWhiteSpace(bySteamID) ||
                _player.SteamID.ToLower().Contains(bySteamID.ToLower()))
                &&
                (registratedFrom == null ||
                _player.RegisteredAt > registratedFrom)
                &&
                (registratedTo == null ||
                _player.RegisteredAt < registratedTo)
                &&
                (mMRFrom == null ||
                _player.MMR < mMRFrom)
                &&
                (mMRTo == null ||
                _player.MMR < mMRTo)
                );

            return filterExpression;
        }

        public Task<Player> GetPlayerByEmail(string email)
        {
            var result = DbSet.Where(p => p.Email.ToLower().Equals(email.ToLower()));

            return result.SingleOrDefaultAsync();
        }

    }
}
