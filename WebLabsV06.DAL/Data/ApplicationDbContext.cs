using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using WebLabsV06.DAL.Entities;

namespace WebLabsV06.DAL.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) 
            :base(options)
        {

        }

        public DbSet<Dish> Dishes { get; set; }
        public DbSet<DishGroup> DishGroups { get; set; }
    }
}
