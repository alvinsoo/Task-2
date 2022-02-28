using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CartApi.Models
{
    public class CartsContext : DbContext
    {
        public CartsContext(DbContextOptions<CartsContext> options)
          : base(options)
        {
        }

        public DbSet<Cart> Carts { get; set; } = null!;
    }
}
