using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Threading.Tasks;

namespace Motorcycles.Database
{
   public  class MotoContext : DbContext
    {



        public MotoContext () : base("MotoConnection")
        {
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
    
    }
}