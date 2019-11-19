using MotoDataBase;
using MotorcyclesEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotorcyclesServices
{
 public   class CategoryService
    {

        public Category GetCategories(int ID)
        {
            using (var context = new MotoContext())
            {
                return context.Categories.Find(ID);
            }
        }

        public List<Category> GetCategories()
        {
            using (var context = new MotoContext())
            {
                return context.Categories.ToList();
            }
        }

        public void SaveCategory (Category category)
        {
            using (var context = new MotoContext())  //عبارة الاتصال 
            {
                context.Categories.Add(category);//استخدمنا تابع الاضافه وضفناه 
                context.SaveChanges();// حفظنا التغييرات 
            }
        }
        public void UpdateCategory(Category category)
        {
            using (var context = new MotoContext())  
            {
                context.Entry(category).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }
        public void DeleteCategory(int ID)
        {
            using (var context = new MotoContext())
            {
                var category = context.Categories.Find(ID);
                    
                context.Categories.Remove(category);
                context.SaveChanges();
            }
        }

    }
}
