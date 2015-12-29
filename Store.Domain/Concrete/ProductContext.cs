using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Store.Domain.Entities;

namespace Store.Domain.Concrete
{
    public class ProductContext : DbContext
    {
        public ProductContext() : base("DbConnect")
        {

        }
        public DbSet<Product> Products { get; set; }
    }

}
