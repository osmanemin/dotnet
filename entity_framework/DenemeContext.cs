using System;
using Microsoft.EntityFrameworkCore;

namespace entity_framework
{
    public class DenemeContext: DbContext
    {
        
        public DbSet<Product> Product { get; set; }

                protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
                {
                        optionsBuilder.UseMySql(@"server=localhost;port=3306;database=deneme;user=root;password=root123;");
                }

    

    }
}