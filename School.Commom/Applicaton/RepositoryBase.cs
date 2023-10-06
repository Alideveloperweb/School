using Microsoft.EntityFrameworkCore;
using School.Commom.Domain;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace School.Commom.Applicaton
{
    public class RepositoryBase<Tkey, TEntity> : IRepositoryBase<Tkey, TEntity>
        where TEntity : class
    {

        #region Constractore

        public DbContext _Context;
        public DbSet<TEntity> db;

        public RepositoryBase(DbContext _Context)
        {
            this._Context = _Context;
            this.db = _Context.Set<TEntity>();
        }

        #endregion

        #region Create

        public async Task<bool> Create(TEntity entity)
        {
            try
            {
                await db.AddAsync(entity);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        #endregion

        #region Create Range

        public async Task<bool> CreateRange(List<TEntity> entities)
        {
            try
            {
                await db.AddRangeAsync(entities);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }


        #endregion

        #region Exist

        public async Task<bool> Exist(Expression<Func<TEntity, bool>> predicate)
        {
            try
            {
                await db.AnyAsync(predicate);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        #endregion

        #region Get

        public async Task<TEntity?> Get(Tkey id)
        {

            return await db.FindAsync(id);

        }

        #endregion

        #region GetAll

        public async Task<List<TEntity>> GetAll()
        {
            return await db.ToListAsync();
        }

        #endregion

        #region Remove

        public bool Remove(TEntity entity)
        {
            try
            {
                db.Remove(entity);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        #endregion

        #region Remove Range

        public bool RemoveRange(List<TEntity> entities)
        {
            try
            {
                db.RemoveRange(entities);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        #endregion

        #region  Save Changes

        public async Task<bool> SaveChanges()
        {
            try
            {
                await _Context.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        #endregion

        #region Update

        public bool Update(TEntity entity)
        {
            try
            {
                db.Update(entity);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        #endregion

    }
}
