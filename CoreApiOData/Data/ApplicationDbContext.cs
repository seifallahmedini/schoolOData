using CoreApiOData.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreApiOData.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
                
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<School>()
                   .HasMany(s => s.Students)
                   .WithOne(s => s.School)
                   .OnDelete(DeleteBehavior.Cascade);
        }

        public DbSet<School> Schools { get; set; }
        public DbSet<Student> Students { get; set; }
    }
}
