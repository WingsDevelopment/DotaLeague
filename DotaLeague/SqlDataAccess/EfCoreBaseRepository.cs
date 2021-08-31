using Domain.RepositoryInterfaces;
using Microsoft.EntityFrameworkCore;
using SqlDataAccess.Contexts;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SqlDataAccess
{
    public class EfCoreBaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class

    {
        internal SqlDotaLeagueContext _context;
        internal DbSet<TEntity> DbSet;

        public EfCoreBaseRepository(SqlDotaLeagueContext context)
        {
            _context = context;
            DbSet = context.Set<TEntity>();
        }

        public virtual async Task InsertMany(IEnumerable<TEntity> entities)
        {
            await DbSet.AddRangeAsync(entities);
        }
        public virtual async Task Insert(TEntity entity)
        {
            await DbSet.AddAsync(entity);
        }
        public async Task<TEntity> GetById(object id)
        {
            var entity = await DbSet.FindAsync(id);

            return entity;
        }
        public virtual async Task<bool> Update(TEntity entity)
        {
            try
            {
                DbSet.Attach(entity);
                _context.Entry(entity).State = EntityState.Modified;

                return await Task.FromResult(true);
            }
            catch (Exception)
            {
                return await Task.FromResult(false);
            }
        }

        public virtual async Task<bool> Delete(TEntity entity)
        {
            DbSet.Remove(entity);

            return await Task.FromResult(true);
        }
        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
