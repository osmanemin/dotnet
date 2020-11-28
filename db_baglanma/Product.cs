using System;
namespace db_baglanma
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int StockAmount { get; set; }
        public decimal UnitPrice { get; set; }
    }
}