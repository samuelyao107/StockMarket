using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace api.Data
{
    public class ApplicationDBContext: IdentityDbContext<AppUser>
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> dbContextOptions )
        : base( dbContextOptions )
        {
            
        }

        public DbSet<Stock> Stocks{ get; set; }
        public DbSet<Comment> Comments{ get; set; }
        public DbSet<Portofolio> Portofolios{ get; set; }

        
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Portofolio>(x=> x.HasKey(p =>new {p.AppUserId, p.StockId}));
            builder.Entity<Portofolio>()
            .HasOne(u => u.AppUser)
            .WithMany(u => u.Portofolio)
            .HasForeignKey(p=>p.AppUserId);

             builder.Entity<Portofolio>()
            .HasOne(u => u.Stock)
            .WithMany(u => u.Portofolio)
            .HasForeignKey(p=>p.StockId);

            List<IdentityRole> roles = new List<IdentityRole>
            {
                new IdentityRole
                {
                    Name= "Admin",
                    NormalizedName ="ADMIN"
                },
                new IdentityRole
                {
                    Name= "User",
                    NormalizedName="USER"
                }
            };
            builder.Entity<IdentityRole>().HasData(roles);
        }
    }
}