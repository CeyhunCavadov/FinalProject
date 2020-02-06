using juan.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace juan.Data
{
    public class JuanDbContext : DbContext
    {
        public JuanDbContext(DbContextOptions<JuanDbContext> options) : base(options)
        {
        }
        public DbSet<Category> Categories { get; set; }
        //public DbSet<> MyProperty { get; set; }
        //public DbSet<> MyProperty { get; set; }
        //public DbSet<> MyProperty { get; set; }
        //public DbSet<> MyProperty { get; set; }
        //public DbSet<> MyProperty { get; set; }
        //public DbSet<> MyProperty { get; set; }
        //public DbSet<> MyProperty { get; set; }
        //public DbSet<> MyProperty { get; set; }
        //public DbSet<> MyProperty { get; set; }
        //public DbSet<> MyProperty { get; set; }
        //public DbSet<> MyProperty { get; set; }
        //public DbSet<> MyProperty { get; set; }
    }
}
