using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotorcyclesEntities
{
    public  class Category: BaseEntity
    {

        public List <Product> Products { get; set; }

    }

   
}
