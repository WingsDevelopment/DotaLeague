using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Domain.RepositoryInterfaces
{
    public interface IBaseRepository<TEntity> : IDisposable where TEntity : class
    {
        //CRUD
        public Task<TEntity> Insert(TEntity entity);
        public Task<TEntity> GetById(string id);
        public Task<TEntity> Update(TEntity entity);
        public Task<TEntity> Delete(string id);
    }
}
