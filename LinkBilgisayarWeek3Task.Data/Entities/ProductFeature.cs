using LinkBilgisayarWeek3Task.Data.Entities.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkBilgisayarWeek3Task.Data.Entities
{
    public class ProductFeature : BaseEntity
    {
        [ForeignKey("Product")]
        public int Id { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public Product Product { get; set; }
    }
}
