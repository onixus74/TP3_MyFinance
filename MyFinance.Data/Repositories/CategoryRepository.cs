using MyFinance.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFinance.Data.Repositories
{
   public class CategoryRepository
    {
        MyFinanceContext ctx = null;
        public CategoryRepository()
        {
            ctx = new MyFinanceContext();
        }
        public void AddCategory(Category c)
        {
            ctx.Categories.Add(c);
            ctx.SaveChanges();

        }
    }
}
