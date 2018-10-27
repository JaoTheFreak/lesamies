using System;
using System.Collections.Generic;
using System.Text;
using Data.LesAmies.Entities;
using Microsoft.EntityFrameworkCore;

namespace Data.LesAmies.Contexts
{
    public class LesAmiesContext : DbContext
    {
        public LesAmiesContext(DbContextOptions<LesAmiesContext> options)
            : base(options)
        {
            
        }


        public DbSet<Product> Products { get; set; }

    }
}
