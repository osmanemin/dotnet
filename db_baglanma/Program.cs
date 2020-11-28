using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
namespace db_baglanma
{
    class Program
    {
        static ProductDal productDal = new ProductDal();
        static void Main(string[] args)
        {
            
            productDal.GetMySqlConnection();
            
            // Add
            /*productDal.Add(new Product{
                Name = "Televizyon",
                UnitPrice = 2758,
                StockAmount = 548
            });*/
            
            Print();

            // Update
            /*productDal.Update(new Product{
                Name = "Avize",
                UnitPrice = 385,
                StockAmount = 123
            },2);
            */
            
            productDal.Delete(3);
            Print();

        }

        static void Print(){
            List<Product> products = productDal.GetAll();
            foreach (var product in products)
            {
                Console.WriteLine(product.Id + "-) " + product.Name + "\t" + product.UnitPrice + "\t" + product.StockAmount);
            }
        }
        
    }
}
