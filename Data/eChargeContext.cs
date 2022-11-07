using eChargeAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace eChargeAPI.Data
{
    public class eChargeContext:DbContext
    {
        public eChargeContext(DbContextOptions<eChargeContext> opt):base(opt)
        {

        }
        public DbSet<Car> Cars { get; set; }
        public DbSet<ChargingPlug> ChargingPlugs { get; set; }
        public DbSet<ChargingPoint> ChargingPoints { get; set; }
        public DbSet<Consumption> Consumptions { get; set; }
        public DbSet<Favourite> Favourites { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<PlugType> PlugTypes { get; set; }
        public DbSet<Privilege> Privileges { get; set; }
        public DbSet<Recipt> Recipts { get; set; }
        public DbSet<Report> Reports { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Station> Stations { get; set; }
        public DbSet<TemplateCar> TemplateCars { get; set; }
        public DbSet<User> Users { get; set; }





    }
}
