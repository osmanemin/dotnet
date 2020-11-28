using System;
using System.Linq;

namespace entity_framework
{
    class Program
    {
        static ProductDal _productDal = new ProductDal();
        static void Main(string[] args)
        {
            _productDal.Add(new Product{
                Name = "Telefon",
                UnitPrice = 1859,
                StockAmount = 336
            });
            
            var result = _productDal.GetAll().Where(p=>p.Name.Contains("e"));
            foreach (var item in result)
            {
                Console.WriteLine(item.Name);
            }
        }
    }
}
