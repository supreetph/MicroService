using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecoomerce.APi.Products.DB
{
    public class ProductDBContext:DbContext
    {
        public ProductDBContext(DbContextOptions options):base(options)
        {

        }
        public DbSet<Product> products { get; set; }
    }
}
