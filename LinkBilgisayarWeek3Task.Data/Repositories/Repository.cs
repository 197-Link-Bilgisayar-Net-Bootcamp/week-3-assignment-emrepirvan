using LinkBilgisayarWeek3Task.Data.Entities;
using LinkBilgisayarWeek3Task.Data.Entities.Common;
using LinkBilgisayarWeek3Task.Data.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkBilgisayarWeek3Task.Data.Repositories
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly LinkDbContext _context;

        public Repository(LinkDbContext context)
        {
            _context = context;
        }

        public async Task Create(T entity)
        {
            await _context.Set<T>().AddAsync(entity);

        }

        public async Task Delete(int id)
        {
            var entity = await GetById(id);
            _context.Set<T>().Remove(entity);

        }

        public IQueryable<T> GetAll()
        {
            return  _context.Set<T>().AsNoTracking();
        }

        public async Task<T> GetById(int id)
        {
            return await _context.Set<T>().AsNoTracking().FirstOrDefaultAsync(e => e.Id == id);
        }



        public async Task Update(int id, T entity)
        {
            _context.Set<T>().Update(entity);
        }
        public async Task SaveChanges()
        {
           await _context.SaveChangesAsync();
        }
    }
}
