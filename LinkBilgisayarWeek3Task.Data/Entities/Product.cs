using LinkBilgisayarWeek3Task.Data.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkBilgisayarWeek3Task.Data.Entities
{
    public class Product : BaseEntity
    {
        public string Name { get; set; }
        public decimal Price { get; set; }

        public int CategoryId { get; set; }
        public int Stock { get; set; }
        public Category Category { get; set; } //Navigation Property //DTO'ya atarken navigation propertleri almıyoruz çünkü bunları sadece EF core kullanıyor

        public ProductFeature ProductFeature { get; set; }
    }
}
