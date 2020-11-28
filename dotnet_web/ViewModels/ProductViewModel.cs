using System.Collections.Generic;
using dotnet_web.Models;

namespace dotnet_web.ViewModels
{
    public class ProductViewModel
    {
        public Category Category { get; set; }
        public List<Product> Products { get; set; }
    }
}