﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFinance.Domain.Entities
{
    public class Provider
    {   
        public int Id { get; set; }
        public string ConfirmPassword { get; set; }
        public DateTime DateCreated { get; set; }
        public string Email { get; set; }
        public bool IsApproved { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        virtual public ICollection<Product> Products { get; set; }
    }
}
