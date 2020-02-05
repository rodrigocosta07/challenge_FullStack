using challenge_API.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace challenge_API.Contexts
{
    public class DbAppContext : DbContext
    {
        public DbAppContext(DbContextOptions<DbAppContext> options) : base(options)
        {

        }

        public DbSet<User> User { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<User>().ToTable("User");
            builder.Entity<User>().HasKey(p => p.Id);
            builder.Entity<User>().Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();
            builder.Entity<User>().Property(p => p.FirstName).IsRequired().HasMaxLength(30);
            builder.Entity<User>().Property(p => p.LastName).IsRequired().HasMaxLength(30);
            builder.Entity<User>().Property(p => p.Participation).IsRequired();

            builder.Entity<User>().HasData(
                new User { Id = 100, FirstName = "Rodrigo" , LastName = "Costa" ,Participation = 20 },
                new User { Id = 102, FirstName = "Teste", LastName = "123", Participation = 30 }
            );
        }
    }
}
