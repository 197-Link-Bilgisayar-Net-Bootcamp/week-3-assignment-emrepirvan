using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkBilgisayarWeek3Task.Data.Entities
{
    public class LinkDbContext :DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductFeature> ProductFeatures { get; set; }
        public LinkDbContext(DbContextOptions<LinkDbContext> options) : base(options)
        {

        }
    }
}
