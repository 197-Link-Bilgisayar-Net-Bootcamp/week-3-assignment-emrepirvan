using LinkBilgisayarWeek3Task.Data.Entities;
using LinkBilgisayarWeek3Task.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkBilgisayarWeek3Task.Data.Repositories
{
    public class CategoryRepository : Repository<Category>, ICategory
    {
        public CategoryRepository(LinkDbContext context) : base(context)
        {
        }
    }
}
