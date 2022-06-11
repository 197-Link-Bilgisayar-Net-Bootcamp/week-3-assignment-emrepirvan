using LinkBilgisayarWeek3Task.Data.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkBilgisayarWeek3Task.Data.Entities
{
    public class Category : BaseEntity
    {
        public string Name { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
