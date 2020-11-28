using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace entity_framework
{
    public class ProductDal
    { 
        public List<Product> GetAll(){
            using (DenemeContext context = new DenemeContext())
            {
                var liste = context.Product.ToList();
                foreach (var item in liste)
                {
                    Console.WriteLine(item.Name);
                }
                return liste;
            }
        }

        public List<Product> GetByName(string key){
            using (DenemeContext context = new DenemeContext())
            {
                var liste = context.Product.Where(p=>p.Name.Contains(key)).ToList();
                foreach (var item in liste)
                {
                    Console.WriteLine(item.Name);
                }
                return liste;
            }
        }

        public void Add(Product product){
            using (DenemeContext context = new DenemeContext())
            {
                // context.Product.Add(product);

                // Benim giriş girişi yapılacak entity' im bu
                var entity = context.Entry(product);
                // bunun işlem durumu ise ekleme veya  silme veya başka bir şey
                entity.State = EntityState.Added;
                context.SaveChanges();
                
            }
        }

        public void Update(Product product){
            using (DenemeContext context = new DenemeContext())
            {
                var entity = context.Entry(product);
                entity.State = EntityState.Modified;
                context.SaveChanges();
                
            }
        }

        

        public void Delete(Product product){
            using (DenemeContext context = new DenemeContext())
            {
                var entity = context.Entry(product);
                entity.State = EntityState.Deleted;
                context.SaveChanges();
                
            }
        }

    }
}