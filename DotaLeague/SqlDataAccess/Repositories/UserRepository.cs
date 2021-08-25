using Domain.RepositoryInterfaces;
using DotaLeague.Domain.Entities;
using SqlDataAccess.Contexts;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SqlDataAccess.Repositories
{
    public class UserRepository : EfCoreBaseRepository<User>, IUserRepository
    {
        public UserRepository(SqlDotaLeagueContext context) : base(context)
        {

        }

        public Task<User> GetUserByEmail(string email)
        {
            throw new NotImplementedException();
        }
    }
}
