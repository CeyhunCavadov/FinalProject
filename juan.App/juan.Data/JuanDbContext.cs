using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace juan.Data
{
    class JuanDbContext : DbContext
    {
        public JuanDbContext(DbContextOptions<JuanDbContext> options) : base(options)
        {
        }
    }
}
