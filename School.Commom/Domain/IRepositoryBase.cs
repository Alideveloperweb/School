using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace School.Commom.Domain
{
    public  interface IRepositoryBase<TKey,TEntity> where TEntity : class
    {
        Task<TEntity?> Get(TKey id);
        Task<List<TEntity>> GetAll();
        Task<bool> Create(TEntity entity);
        Task<bool> CreateRange(List<TEntity> entities);
        bool Update(TEntity entity);
        bool Remove(TEntity entity);
        bool RemoveRange(List<TEntity> entities);
        Task<bool> Exist(Expression<Func<TEntity, bool>> predicate);
        Task<bool> SaveChanges();
    }
}
