using MyFinance.Data.Repositories;
using MyFinance.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFinance.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            CategoryRepository crepo = new CategoryRepository();
            Category c = new Category { Name = "Bioware"};

        }
    }
}
