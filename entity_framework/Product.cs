using System.ComponentModel.DataAnnotations;

namespace entity_framework
{
    public class Product
    {
        public int Id { get; set; }
        
        // zorunlu alan demek
        [Required]
        [MaxLength(45)]
        public string Name { get; set; }
        public int StockAmount { get; set; }
        public decimal UnitPrice { get; set; }
    }
}