﻿using MotorcyclesEntities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotoDataBase
{
    public class MotoContext :DbContext ,IDisposable
    {
        public MotoContext() : base("MotoConnection")
        {
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
    }


}
