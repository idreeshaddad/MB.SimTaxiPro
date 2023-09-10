using MB.SimTaxiPro.Entities;
using Microsoft.EntityFrameworkCore;

namespace MB.SimTaxiPro.EntityFrameworkCore
{
    public class SimTaxiProDbContext : DbContext
    {
        public DbSet<Car> Cars { get; set; }
        public DbSet<Driver> Drivers { get; set; }
        public DbSet<Passenger> Passengers { get; set; }

        public SimTaxiProDbContext(DbContextOptions<SimTaxiProDbContext> options)
        : base(options) { }
    }
}
