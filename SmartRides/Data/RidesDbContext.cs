using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using SmartRides.Models.Entities;
using System;

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
        public DbSet<Bus> Buses { get; set; }
        public DbSet<Driver> Drivers { get; set; }
        public DbSet<Seat> Seats { get; set; }
        public DbSet<BusSeat> BusSeats { get; set; }
        public DbSet<User> RideUsers { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            #region Identity

            builder
                .HasAnnotation("ProductVersion", "3.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            builder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
            {
                b.Property<string>("Id")
                    .HasColumnType("nvarchar(450)");

                b.Property<string>("ConcurrencyStamp")
                    .IsConcurrencyToken()
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("Name")
                    .HasColumnType("nvarchar(256)")
                    .HasMaxLength(256);

                b.Property<string>("NormalizedName")
                    .HasColumnType("nvarchar(256)")
                    .HasMaxLength(256);

                b.HasKey("Id");

                b.HasIndex("NormalizedName")
                    .IsUnique()
                    .HasName("RoleNameIndex")
                    .HasFilter("[NormalizedName] IS NOT NULL");

                b.ToTable("AspNetRoles");
            });

            builder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int")
                    .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                b.Property<string>("ClaimType")
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("ClaimValue")
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("RoleId")
                    .IsRequired()
                    .HasColumnType("nvarchar(450)");

                b.HasKey("Id");

                b.HasIndex("RoleId");

                b.ToTable("AspNetRoleClaims");
            });

            builder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
            {
                b.Property<string>("Id")
                    .HasColumnType("nvarchar(450)");

                b.Property<int>("AccessFailedCount")
                    .HasColumnType("int");

                b.Property<string>("ConcurrencyStamp")
                    .IsConcurrencyToken()
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("Email")
                    .HasColumnType("nvarchar(256)")
                    .HasMaxLength(256);

                b.Property<bool>("EmailConfirmed")
                    .HasColumnType("bit");

                b.Property<bool>("LockoutEnabled")
                    .HasColumnType("bit");

                b.Property<DateTimeOffset?>("LockoutEnd")
                    .HasColumnType("datetimeoffset");

                b.Property<string>("NormalizedEmail")
                    .HasColumnType("nvarchar(256)")
                    .HasMaxLength(256);

                b.Property<string>("NormalizedUserName")
                    .HasColumnType("nvarchar(256)")
                    .HasMaxLength(256);

                b.Property<string>("PasswordHash")
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("PhoneNumber")
                    .HasColumnType("nvarchar(max)");

                b.Property<bool>("PhoneNumberConfirmed")
                    .HasColumnType("bit");

                b.Property<string>("SecurityStamp")
                    .HasColumnType("nvarchar(max)");

                b.Property<bool>("TwoFactorEnabled")
                    .HasColumnType("bit");

                b.Property<string>("UserName")
                    .HasColumnType("nvarchar(256)")
                    .HasMaxLength(256);

                b.HasKey("Id");

                b.HasIndex("NormalizedEmail")
                    .HasName("EmailIndex");

                b.HasIndex("NormalizedUserName")
                    .IsUnique()
                    .HasName("UserNameIndex")
                    .HasFilter("[NormalizedUserName] IS NOT NULL");

                b.ToTable("AspNetUsers");
            });

            builder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int")
                    .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                b.Property<string>("ClaimType")
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("ClaimValue")
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("UserId")
                    .IsRequired()
                    .HasColumnType("nvarchar(450)");

                b.HasKey("Id");

                b.HasIndex("UserId");

                b.ToTable("AspNetUserClaims");
            });

            builder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
            {
                b.Property<string>("LoginProvider")
                    .HasColumnType("nvarchar(128)")
                    .HasMaxLength(128);

                b.Property<string>("ProviderKey")
                    .HasColumnType("nvarchar(128)")
                    .HasMaxLength(128);

                b.Property<string>("ProviderDisplayName")
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("UserId")
                    .IsRequired()
                    .HasColumnType("nvarchar(450)");

                b.HasKey("LoginProvider", "ProviderKey");

                b.HasIndex("UserId");

                b.ToTable("AspNetUserLogins");
            });

            builder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
            {
                b.Property<string>("UserId")
                    .HasColumnType("nvarchar(450)");

                b.Property<string>("RoleId")
                    .HasColumnType("nvarchar(450)");

                b.HasKey("UserId", "RoleId");

                b.HasIndex("RoleId");

                b.ToTable("AspNetUserRoles");
            });

            builder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
            {
                b.Property<string>("UserId")
                    .HasColumnType("nvarchar(450)");

                b.Property<string>("LoginProvider")
                    .HasColumnType("nvarchar(128)")
                    .HasMaxLength(128);

                b.Property<string>("Name")
                    .HasColumnType("nvarchar(128)")
                    .HasMaxLength(128);

                b.Property<string>("Value")
                    .HasColumnType("nvarchar(max)");

                b.HasKey("UserId", "LoginProvider", "Name");

                b.ToTable("AspNetUserTokens");
            });

            builder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
            {
                b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                    .WithMany()
                    .HasForeignKey("RoleId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();
            });

            builder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
            {
                b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                    .WithMany()
                    .HasForeignKey("UserId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();
            });

            builder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
            {
                b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                    .WithMany()
                    .HasForeignKey("UserId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();
            });

            builder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
            {
                b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                    .WithMany()
                    .HasForeignKey("RoleId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                    .WithMany()
                    .HasForeignKey("UserId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();
            });

            builder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
            {
                b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                    .WithMany()
                    .HasForeignKey("UserId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();
            });

            #endregion

            #region Location

            builder.Entity<Location>()
                .ToTable("Location");

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
                .ToTable("Ride");

            builder.Entity<Ride>()
                .HasKey(p => p.RideId);

            builder.Entity<Ride>()
                .HasOne(p => p.StartPoint)
                .WithMany(l => l.StartPoints)
                .HasForeignKey(p => p.StartPointId)
                .HasConstraintName("StartPoint_FK")
                .OnDelete(DeleteBehavior.NoAction);

            builder.Entity<Ride>()
                .HasOne(p => p.DestinationPoint)
                .WithMany(l => l.DestinationPoints)
                .HasForeignKey(p => p.DestinationPointId)
                .HasConstraintName("DestinationPoint_FK")
                .OnDelete(DeleteBehavior.NoAction);

            #endregion

            #region Ride stops

            builder.Entity<RideStop>()
                .ToTable("RideStop");

            builder.Entity<RideStop>()
                .HasKey(p => p.RideStopId);

            builder.Entity<RideStop>()
                .HasOne(p => p.Ride)
                .WithMany(r => r.RideStops)
                .HasForeignKey(p => p.RideId)
                .HasConstraintName("Ride_FK")
                .OnDelete(DeleteBehavior.NoAction);

            builder.Entity<RideStop>()
                .HasOne(p => p.Location)
                .WithMany(l => l.RideStops)
                .HasForeignKey(p => p.LocationId)
                .HasConstraintName("Location_FK")
                .OnDelete(DeleteBehavior.NoAction);

            #endregion

            #region Bus

            builder.Entity<Bus>()
                .ToTable(nameof(Bus));

            builder.Entity<Bus>()
                .HasKey(p => p.BusId);

            builder.Entity<Bus>()
                .HasOne(p => p.Driver)
                .WithOne(d => d.Bus)
                .HasForeignKey<Driver>(d => d.BusId)
                .HasConstraintName("Driver_FK")
                .OnDelete(DeleteBehavior.NoAction);

            #endregion

            #region Driver

            builder.Entity<Driver>()
                .ToTable(nameof(Driver));

            builder.Entity<Driver>()
                .HasKey(p => p.DriverId);

            builder.Entity<Driver>()
                .Property(p => p.Salary)
                .HasColumnType("decimal(5,3)");

            #endregion

            #region Seat

            builder.Entity<Seat>()
                .ToTable(nameof(Seat));

            builder.Entity<Seat>()
                .HasKey(p => p.SeatId);

            #endregion

            #region Bus Seat

            builder.Entity<BusSeat>()
                .ToTable(nameof(BusSeat));

            builder.Entity<BusSeat>()
                .HasKey(p => p.BusSeatId);

            builder.Entity<BusSeat>()
                .HasOne(p => p.Bus)
                .WithMany(b => b.BusSeats)
                .HasForeignKey(p => p.BusId)
                .HasConstraintName("Bus_FK");

            builder.Entity<BusSeat>()
                .HasOne(p => p.Seat)
                .WithMany(s => s.BusSeats)
                .HasForeignKey(p => p.SeatId)
                .HasConstraintName("Seat_FK");

            #endregion

            #region User

            builder.Entity<User>()
                .ToTable("Users");

            builder.Entity<User>()
                .HasKey(p => p.UserId);

            builder.Entity<User>()
                .Property(p => p.FirstName)
                .IsRequired()
                .HasMaxLength(150);

            builder.Entity<User>()
                .Property(p => p.LastName)
                .IsRequired()
                .HasMaxLength(150);

            builder.Entity<User>()
                .Property(p => p.Login)
                .IsRequired(false);

            builder.Entity<User>()
                .Property(p => p.Password)
                .IsRequired(false);

            #endregion

            #region Customer

            builder.Entity<Customer>()
                .Property(p => p.PersonalIdentifier)
                .HasMaxLength(250)
                .IsRequired();

            builder.Entity<Customer>()
                .Property(p => p.Birthdate)
                .HasColumnType("date");

            #endregion

            #region Employee

            builder.Entity<Employee>()
                .Property(p => p.HireDate)
                .HasColumnType("date");

            builder.Entity<Employee>()
                .Property(p => p.Discount)
                .HasPrecision(2);

            #endregion

            #region Ride Date

            builder.Entity<RideDate>()
                .ToTable("RideDate");

            builder.Entity<RideDate>()
                .HasKey(p => p.RideDateId);

            builder.Entity<RideDate>()
                .HasOne(p => p.Ride)
                .WithMany(r => r.RideDates)
                .HasForeignKey(p => p.RideId)
                .HasConstraintName("Ride_FK")
                .OnDelete(DeleteBehavior.NoAction);

            builder.Entity<RideDate>()
                .Property(p => p.Date)
                .HasColumnType("date");

            #endregion

            #region Ride Schedule

            builder.Entity<RideSchedule>()
                .ToTable("RideSchedule");

            builder.Entity<RideSchedule>()
                .HasKey(p => p.RideScheduleId);

            builder.Entity<RideSchedule>()
                .HasOne(p => p.RideDate)
                .WithMany(rd => rd.RideSchedules)
                .HasForeignKey(p => p.RideDateId)
                .HasConstraintName("RideDate_FK")
                .OnDelete(DeleteBehavior.NoAction);

            #endregion

        }
    }
}
