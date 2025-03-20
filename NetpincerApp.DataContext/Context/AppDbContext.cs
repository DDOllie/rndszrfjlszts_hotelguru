using Microsoft.EntityFrameworkCore;
using NetPincerApp.DataContext.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetpincerApp.DataContext.Context
{
    public class AppDbContext : DbContext
    {
        public DbSet<Room> Users { get; set; }
        public DbSet<Booking> Restaurants { get; set; }
        public DbSet<UnregisteredUser> Foods { get; set; }
        public DbSet<Bookings> FoodCategories { get; set; }
        public DbSet<RegisteredUser> Orders { get; set; }
        public DbSet<ExtraService> OrderItems { get; set; }
        public DbSet<Rooms> Roles { get; set; }
        public DbSet<User> Addresses { get; set; }


        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
    }
}
