﻿using Domains.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace E_commerce.Repository
{
     public abstract class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        protected ApplicationDbContext context { get; set; }
        protected DbSet<T> DbSet { get; set; }
        public BaseRepository(ApplicationDbContext _context)
        {
            this.context = _context;
            DbSet = context.Set<T>();
        }
        public async Task AddAsync(T entity)
        {
            await this.DbSet.AddAsync(entity);
        }
        public async Task AddRangeAsync(IEnumerable<T> entities)
        {
            await this.DbSet.AddRangeAsync(entities);
        }
        public void Detach(T entity)
        {
            var local = this.DbSet.Local.FirstOrDefault();
            if (local != null)
            {
                context.Entry(local).State = EntityState.Detached;
            }
        }
        public void UpdateAsync(T entity)
        {
            DbSet.Attach(entity);
            context.Entry(entity).State = EntityState.Modified;
        }

        public void UpdateRangeAsync(List<T> entities)
        {
            DbSet.UpdateRange(entities);
        }
        public void Remove(T entity)
        {
            this.DbSet.Remove(entity);
        }
        public void RemoveRange(IEnumerable<T> entities)
        {
            this.DbSet.RemoveRange(entities);
        }
        public async Task<T> GetAsync(Expression<Func<T, bool>> expression)
        {
            return await this.DbSet.Where(expression).AsNoTracking().FirstOrDefaultAsync();
        }
        public T Get(Expression<Func<T, bool>> expression)
        {
            return this.DbSet.Where(expression).AsNoTracking().FirstOrDefault();
        }
        public IQueryable<T> GetMany(Expression<Func<T, bool>> expression)
        {
            return this.DbSet.Where(expression).AsNoTracking().AsQueryable();
        }
        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await this.DbSet.AsNoTracking().ToListAsync();
        }
        public IQueryable<T> Include(Expression<Func<T, bool>> filter, params Expression<Func<T, object>>[] includeExpressions)
        {
            DbSet<T> dbSet = DbSet;
            includeExpressions.ToList().ForEach(x => DbSet.Include(x).Load());
            return DbSet;
        }
        public async Task<IEnumerable<T>> ExcuteQuerys(string query, params object[] parameters)
        {
            return await DbSet.FromSqlRaw(query, parameters).ToListAsync();
        }

        public async Task<dynamic> ExcuteQuery(string query, params object[] parameters)
        {
            return await DbSet.FromSqlRaw(query, parameters).FirstOrDefaultAsync();
        }
        public async Task<dynamic> ExcuteQueryList(string query, params object[] parameters)
        {
            return await DbSet.FromSqlRaw(query, parameters).ToListAsync();
        }

    }
}
