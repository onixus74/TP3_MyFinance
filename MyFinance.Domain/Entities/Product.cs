using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFinance.Domain.Entities
{
   public class Product
    {
        public DateTime DateProd { get; set; }
        public int ProductId { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        virtual public ICollection<Provider> Providers { get; set; }
        virtual public Category Category { get; set; }
        public int? CategoryId { get; set; }
    }
}
