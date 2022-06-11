using LinkBilgisayarWeek3Task.Data.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkBilgisayarWeek3Task.Data.Interfaces
{
    public interface IRepository<T> where T : BaseEntity
    {
        IQueryable<T> GetAll();
        Task<T> GetById(int id);
        Task Create(T entity);
        Task Update(int id,T entity);
        Task Delete(int id);
        Task SaveChanges();

    }
}
