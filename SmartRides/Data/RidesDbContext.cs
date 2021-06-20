using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SmartRides.Models.Entities;

namespace SmartRides.Data
{
    public class RidesDbContext : IdentityDbContext
    {
        public RidesDbContext(DbContextOptions<RidesDbContext> options)
            : base(options)
        {
        }

        public DbSet<Location> Locations { get; set; }
        public DbSet<Ride> Rides { get; set; }
        public DbSet<RideStop> RideStops { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            #region Location

            builder.Entity<Location>()
                .HasKey(p => p.LocationId);

            builder.Entity<Location>()
                .Property(p => p.LocationName)
                .HasMaxLength(100)
                .IsRequired();

            builder.Entity<Location>()
                .Property(p => p.StationName)
                .HasMaxLength(100)
                .IsRequired();

            #endregion

            #region Ride

            builder.Entity<Ride>()
                .HasKey(p => p.RideId);

            builder.Entity<Ride>()
                .Property(p => p.TotalHours)
                .IsRequired(false);

            builder.Entity<Ride>()
                .HasOne(p => p.StartPoint)
                .WithMany(l => l.StartPoints)
                .HasForeignKey(p => p.StartPointId)
                .HasConstraintName("StartPoint_FK");

            builder.Entity<Ride>()
                .HasOne(p => p.DestinationPoint)
                .WithMany(l => l.DestinationPoints)
                .HasForeignKey(p => p.DestinationPointId)
                .HasConstraintName("DestinationPoint_FK");

            #endregion

            #region Ride stops

            builder.Entity<RideStop>()
                .HasKey(p => p.RideStopId);

            builder.Entity<RideStop>()
                .HasOne(p => p.Ride)
                .WithMany(r => r.RideStops)
                .HasForeignKey(p => p.RideId)
                .HasConstraintName("Ride_FK");

            builder.Entity<RideStop>()
                .HasOne(p => p.Location)
                .WithMany(l => l.RideStops)
                .HasForeignKey(p => p.LocationId)
                .HasConstraintName("Location_FK");

            #endregion
        }
    }
}
