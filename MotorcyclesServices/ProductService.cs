using MotoDataBase;
using MotorcyclesEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotorcyclesServices
{
 public   class ProductService
    {

        public Product GetProduct(int ID)
        {
            using (var context = new MotoContext())
            {
                return context.Products.Find(ID);
            }
        }

        public List<Product> GetProducts()
        {
            using (var context = new MotoContext())
            {
                return context.Products.ToList();
            }
        }

        public void SaveProduct(Product product)
        {
            using (var context = new MotoContext())  //عبارة الاتصال 
            {
                context.Products.Add(product);//استخدمنا تابع الاضافه وضفناه 
                context.SaveChanges();// حفظنا التغييرات 
            }
        }
        public void UpdateProduct(Product product)
        {
            using (var context = new MotoContext())  
            {
                context.Entry(product).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }
        public void DeleteProduct(int ID)
        {
            using (var context = new MotoContext())
            {
                var product = context.Products.Find(ID);
                    
                context.Products.Remove(product);
                context.SaveChanges();
            }
        }


    }
}
