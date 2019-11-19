using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotorcyclesEntities
{
  public   class Product : BaseEntity
    {

 

        public decimal ProductPrice { get; set; }
      
        public Category Category { get; set; }
    }

   
}
