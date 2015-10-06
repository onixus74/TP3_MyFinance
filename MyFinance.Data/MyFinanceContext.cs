using MyFinance.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MyFinance.Data
{
    class MyFinanceContext : DbContext
    {
        public MyFinanceContext() : base("MyFinanceDB") { };
        public DbSet<Product> Products { get; set; }
        public DbSet<Provider> Providers { get; set; }

        public DbSet<Category> Categories { get; set; }
    }
}
