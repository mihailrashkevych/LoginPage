using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoginPage.Models
{
    public class AppDbContext : DbContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(new User() { Id = 101, Name = "Misha", Email = "misha@rash.com", Password = "123" }); ;
        }

        public AppDbContext( DbContextOptions options ) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
    }
}
