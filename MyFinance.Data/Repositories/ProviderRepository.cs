using MyFinance.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFinance.Data.Repositories
{
    public class ProviderRepository
    {
        MyFinanceContext ctx = null;
        public ProviderRepository()
        {
            ctx = new MyFinanceContext();
        }
        public void AddProvider(Provider p)
        {
            ctx.Providers.Add(p);
            ctx.SaveChanges();

        }
    }
}
