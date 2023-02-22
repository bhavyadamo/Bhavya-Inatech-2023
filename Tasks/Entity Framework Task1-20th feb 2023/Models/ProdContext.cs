using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace EFConsole.Models
{
    internal class ProdContext:DbContext
    {
        private const string connectionString="Server=(localdb)\\mssqllocaldb;Database=ProdCore;Trusted_Connection=True;"; //ProdCore is the name tha that give
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductBatch> ProductBatchs { get; set; }
        public DbSet<Student>Students { get; set; }
        public DbSet<Standard> Standards { get; set; }
    }

    
}
