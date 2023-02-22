using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using KoreMvc.Models;

namespace KoreMvc.Data
{
    public class KoreMvcContext : DbContext
    {
        public KoreMvcContext (DbContextOptions<KoreMvcContext> options)
            : base(options)
        {
        }

        public DbSet<KoreMvc.Models.Customer> Customer { get; set; } = default!;
    }
}
