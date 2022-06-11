using LinkBilgisayarWeek3Task.Data.Entities;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkBilgisayarWeek3Task.Data.UnitOfWork
{
    public class UnitOfWork
    {
        private readonly LinkDbContext _context;

        public UnitOfWork(LinkDbContext context)
        {
            _context = context;
        }

        public async Task Commit()
        {
            await _context.SaveChangesAsync();
        }
        //UnitOfwork kullandıgımızda açık açık transaction metotlarını yazmamız gerekiyor
        public IDbContextTransaction BeginTransaction()
        {
            return _context.Database.BeginTransaction();
        }
    }
}
