using bookstore.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace bookstore.Core.DataAccess.EntityFramework
{
    public class EntityRepository<T> : IEntityRepository<T>  where T : class, IEntity, new()
    {
        public DbContext _context;
        public DbSet<T> dbSet;

        public EntityRepository(DbContext context)
        {
            _context = context;
            dbSet = context.Set<T>();
        }

        public async Task Add(T entity)
        {
            dbSet.Add(entity);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(T entity)
        {
            dbSet.Remove(entity);
            await _context.SaveChangesAsync();
        }

        public async Task<T> Get(Expression<Func<T, bool>> filter)
        {
            return await dbSet.FirstOrDefaultAsync(filter);
        }

        public async Task<IList<T>> GetList(System.Linq.Expressions.Expression<Func<T, bool>> filter = null)
        {
            var list = await dbSet.ToListAsync();
            return list;
        }

        public async Task Update(T entity)
        {
            dbSet.Update(entity);
            await _context.SaveChangesAsync();
        }
    }
}
