using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPINorthWind.Models
{
    public class NorthWindContext:DbContext
    {
        public NorthWindContext(DbContextOptions<NorthWindContext> options)

    : base(options)
        {


        }

            public DbSet<Product> Products { get; set; }

    }
}
