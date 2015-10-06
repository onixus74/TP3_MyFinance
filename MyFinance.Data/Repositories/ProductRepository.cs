using MyFinance.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFinance.Data.Repositories
{
   public class ProductRepository
    {
        MyFinanceContext ctx = null;
        public ProductRepository()
        {
            ctx = new MyFinanceContext();
        }
        public void AddProduct(Product p)
        {
            ctx.Products.Add(p);
            ctx.SaveChanges();

        }
    }
}
