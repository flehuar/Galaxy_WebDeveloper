﻿using DbModel.CICLOUD;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Repository
{
    public class CrudRepository<TEntity> where TEntity : class
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IConfiguration _configuration;
        internal _CicloudContext _db;
        internal DbSet<TEntity> dbSet;
        public CrudRepository(IHttpContextAccessor httpContextAccessor, IConfiguration configuration)
        {
            _configuration = configuration;
            _httpContextAccessor = httpContextAccessor;
            _db = new _CicloudContext(httpContextAccessor, configuration);
            this.dbSet = _db.Set<TEntity>();
        }


        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public virtual async Task<List<TEntity>> GetAll()
        {

            IQueryable<TEntity> query = dbSet;
            //ToListAsync => select * from table
            return await query.ToListAsync();
        }

        public virtual async Task<TEntity> GetById(object id)
        {

#pragma warning disable CS8603 // Possible null reference return.
            return await dbSet.FindAsync(id);
#pragma warning restore CS8603 // Possible null reference return.
        }

        public virtual async Task<TEntity> Create(TEntity entity)
        {
            await dbSet.AddAsync(entity);
            await _db.SaveChangesAsync();
            return entity;

        }

        public virtual async Task<TEntity> Update(TEntity entity)
        {

            dbSet.Update(entity);
            await _db.SaveChangesAsync();
            return entity;

        }


        public virtual async Task<int> Delete(object id)
        {
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
            TEntity entityToDelete = await dbSet.FindAsync(id);
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
            int rows = 0;
            if (entityToDelete != null)
            {
                dbSet.Remove(entityToDelete);
                rows = await _db.SaveChangesAsync();
            }
            return rows;
        }

        public virtual async Task<int> DeleteMultipleItems(List<TEntity> lista)
        {
            dbSet.RemoveRange(lista);
            return await _db.SaveChangesAsync();

        }
        public virtual async Task<List<TEntity>> CreateMultipleItems(List<TEntity> lista)
        {

            await dbSet.AddRangeAsync(lista);
            await _db.SaveChangesAsync();
            return lista;
        }
        public virtual async Task<List<TEntity>> UpdateMultiple(List<TEntity> lista)
        {
            dbSet.UpdateRange(lista);
            await _db.SaveChangesAsync();
            return lista;
        }
    }
}
