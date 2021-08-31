using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Domain.RepositoryInterfaces
{
    public interface IBaseRepository<TEntity> : IDisposable where TEntity : class
    {
        //CRUD
        public Task Insert(TEntity entity);
        public Task<TEntity> GetById(object id);
        public Task<bool> Update(TEntity entity);
        public Task<bool> Delete(TEntity entity);
        public Task InsertMany(IEnumerable<TEntity> entities)
    }
}
