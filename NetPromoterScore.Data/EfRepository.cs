using Microsoft.EntityFrameworkCore;
using NetPromoterScore.Entity;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;

namespace NetPromoterScore.Data
{
    public class EfRepository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly IDbContext _context;
        private DbSet<T> _entities;

        public EfRepository(IDbContext context) => _context = context;

        public IQueryable<T> Table
        {
            get
            {
                return this.Entities;
            }
        }

        public async ValueTask<int> DeleteAsync(T entity)
        {

            if (entity == null)
                throw new ArgumentNullException("entity");

            Entities.Remove(entity);
            return await _context.SaveChangesAsync();

        }

        public async ValueTask<T> GetByIdAsync(object id)
        {
            return await Entities.FindAsync(id);
        }

        public async ValueTask<int> InsertAsync(T entity)
        {
            if (entity == null)
                throw new ArgumentNullException("entity");

            Entities.Add(entity);

            return await _context.SaveChangesAsync();
        }

        public async ValueTask<int> UpdateAsync(T entity)
        {

            if (entity == null)
                throw new ArgumentNullException("entity");

            Entities.Update(entity);

            return await _context.SaveChangesAsync();

        }

        protected virtual DbSet<T> Entities
        {
            get
            {
                if (_entities == null)
                    _entities = _context.Set<T>();
                return _entities;
            }
        }

    }
}
