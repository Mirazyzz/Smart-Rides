﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SmartRides.Data;

namespace SmartRides.Data.Migrations
{
    [DbContext(typeof(RidesDbContext))]
    [Migration("20210620172513_DropDisplaying")]
    partial class DropDisplaying
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "3.0.0")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
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

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

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
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
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

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("SmartRides.Models.Entities.AvailableSeat", b =>
                {
                    b.Property<int>("AvailableSeatId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BusId")
                        .HasColumnType("int");

                    b.Property<bool>("IsAvailable")
                        .HasColumnType("bit");

                    b.Property<int>("RideScheduleId")
                        .HasColumnType("int");

                    b.Property<int>("SeatId")
                        .HasColumnType("int");

                    b.HasKey("AvailableSeatId");

                    b.HasIndex("BusId");

                    b.HasIndex("RideScheduleId");

                    b.HasIndex("SeatId");

                    b.ToTable("AvailableSeat");
                });

            modelBuilder.Entity("SmartRides.Models.Entities.Bus", b =>
                {
                    b.Property<int>("BusId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("FloorCount")
                        .HasColumnType("int");

                    b.Property<bool>("HasAirCondition")
                        .HasColumnType("bit");

                    b.Property<bool>("HasBuffet")
                        .HasColumnType("bit");

                    b.Property<bool>("HasCharger")
                        .HasColumnType("bit");

                    b.Property<int>("SeatCount")
                        .HasColumnType("int");

                    b.HasKey("BusId");

                    b.ToTable("Bus");
                });

            modelBuilder.Entity("SmartRides.Models.Entities.DiscountReason", b =>
                {
                    b.Property<int>("DiscountReasonId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DiscountName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DiscountReasonId");

                    b.ToTable("DiscountReason");
                });

            modelBuilder.Entity("SmartRides.Models.Entities.Driver", b =>
                {
                    b.Property<int>("DriverId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BusId")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("HireDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Salary")
                        .HasColumnType("decimal(5,3)");

                    b.HasKey("DriverId");

                    b.HasIndex("BusId")
                        .IsUnique();

                    b.ToTable("Driver");
                });

            modelBuilder.Entity("SmartRides.Models.Entities.Location", b =>
                {
                    b.Property<int>("LocationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("LocationName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("StationName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("LocationId");

                    b.ToTable("Location");
                });

            modelBuilder.Entity("SmartRides.Models.Entities.Ride", b =>
                {
                    b.Property<int>("RideId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DestinationPointId")
                        .HasColumnType("int");

                    b.Property<int>("StartPointId")
                        .HasColumnType("int");

                    b.Property<double>("TotalHours")
                        .HasColumnType("float");

                    b.HasKey("RideId");

                    b.HasIndex("DestinationPointId");

                    b.HasIndex("StartPointId");

                    b.ToTable("Ride");
                });

            modelBuilder.Entity("SmartRides.Models.Entities.RideDate", b =>
                {
                    b.Property<int>("RideDateId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date")
                        .HasColumnType("date");

                    b.Property<int>("RideId")
                        .HasColumnType("int");

                    b.HasKey("RideDateId");

                    b.HasIndex("RideId");

                    b.ToTable("RideDate");
                });

            modelBuilder.Entity("SmartRides.Models.Entities.RideSchedule", b =>
                {
                    b.Property<int>("RideScheduleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DisplayingId")
                        .HasColumnType("int");

                    b.Property<int>("RideDateId")
                        .HasColumnType("int");

                    b.Property<int>("ScheduleId")
                        .HasColumnType("int");

                    b.HasKey("RideScheduleId");

                    b.HasIndex("RideDateId");

                    b.HasIndex("ScheduleId");

                    b.ToTable("RideSchedule");
                });

            modelBuilder.Entity("SmartRides.Models.Entities.RideStop", b =>
                {
                    b.Property<int>("RideStopId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("LocationId")
                        .HasColumnType("int");

                    b.Property<int>("RideId")
                        .HasColumnType("int");

                    b.HasKey("RideStopId");

                    b.HasIndex("LocationId");

                    b.HasIndex("RideId");

                    b.ToTable("RideStop");
                });

            modelBuilder.Entity("SmartRides.Models.Entities.Schedule", b =>
                {
                    b.Property<int>("ScheduleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("ArrivalTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DepartureTime")
                        .HasColumnType("datetime2");

                    b.HasKey("ScheduleId");

                    b.ToTable("Schedule");
                });

            modelBuilder.Entity("SmartRides.Models.Entities.Seat", b =>
                {
                    b.Property<int>("SeatId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Column")
                        .HasColumnType("int");

                    b.Property<bool>("IsAtWindow")
                        .HasColumnType("bit");

                    b.Property<int>("Row")
                        .HasColumnType("int");

                    b.HasKey("SeatId");

                    b.ToTable("Seat");
                });

            modelBuilder.Entity("SmartRides.Models.Entities.Ticket", b =>
                {
                    b.Property<int>("TicketId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<int>("DiscountReasonId")
                        .HasColumnType("int");

                    b.Property<int>("DisplayingId")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("TicketClassAttributeId")
                        .HasColumnType("int");

                    b.Property<string>("TicketNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TicketStatus")
                        .HasColumnType("int");

                    b.Property<int>("TicketType")
                        .HasColumnType("int");

                    b.HasKey("TicketId");

                    b.HasIndex("CustomerId");

                    b.HasIndex("DiscountReasonId");

                    b.HasIndex("TicketClassAttributeId");

                    b.ToTable("Ticket");
                });

            modelBuilder.Entity("SmartRides.Models.Entities.TicketClassAttribute", b =>
                {
                    b.Property<int>("TicketClassAttributeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("DiscountRate")
                        .HasColumnType("float");

                    b.Property<decimal>("StandardPrice")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("TicketClassAttributeId");

                    b.ToTable("TicketClassAttribute");
                });

            modelBuilder.Entity("SmartRides.Models.Entities.TicketSeat", b =>
                {
                    b.Property<int>("TicketSeatId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("SeatId")
                        .HasColumnType("int");

                    b.Property<int>("TicketId")
                        .HasColumnType("int");

                    b.HasKey("TicketSeatId");

                    b.HasIndex("SeatId");

                    b.HasIndex("TicketId");

                    b.ToTable("TicketSeat");
                });

            modelBuilder.Entity("SmartRides.Models.Entities.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("Login")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("PromoCode")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("UserId");

                    b.ToTable("Users");

                    b.HasDiscriminator<string>("Discriminator").HasValue("User");
                });

            modelBuilder.Entity("SmartRides.Models.Entities.Customer", b =>
                {
                    b.HasBaseType("SmartRides.Models.Entities.User");

                    b.Property<DateTime>("Birthdate")
                        .HasColumnType("date");

                    b.Property<int>("CustomerType")
                        .HasColumnType("int");

                    b.Property<double>("Discount")
                        .HasColumnType("float")
                        .HasColumnName("Customer_Discount");

                    b.Property<string>("PersonalIdentifier")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("Customer");
                });

            modelBuilder.Entity("SmartRides.Models.Entities.Employee", b =>
                {
                    b.HasBaseType("SmartRides.Models.Entities.User");

                    b.Property<decimal>("Discount")
                        .HasPrecision(2)
                        .HasColumnType("decimal(2,2)");

                    b.Property<DateTime>("HireDate")
                        .HasColumnType("date");

                    b.HasDiscriminator().HasValue("Employee");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
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

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SmartRides.Models.Entities.AvailableSeat", b =>
                {
                    b.HasOne("SmartRides.Models.Entities.Bus", "Bus")
                        .WithMany("AvailableSeats")
                        .HasForeignKey("BusId")
                        .HasConstraintName("Bus_FK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SmartRides.Models.Entities.RideSchedule", "RideSchedule")
                        .WithMany("AvailableSeats")
                        .HasForeignKey("RideScheduleId")
                        .HasConstraintName("AvailableSeat_FK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SmartRides.Models.Entities.Seat", "Seat")
                        .WithMany("AvailableSeats")
                        .HasForeignKey("SeatId")
                        .HasConstraintName("Seat_FK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Bus");

                    b.Navigation("RideSchedule");

                    b.Navigation("Seat");
                });

            modelBuilder.Entity("SmartRides.Models.Entities.Driver", b =>
                {
                    b.HasOne("SmartRides.Models.Entities.Bus", "Bus")
                        .WithOne("Driver")
                        .HasForeignKey("SmartRides.Models.Entities.Driver", "BusId")
                        .HasConstraintName("Driver_FK")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Bus");
                });

            modelBuilder.Entity("SmartRides.Models.Entities.Ride", b =>
                {
                    b.HasOne("SmartRides.Models.Entities.Location", "DestinationPoint")
                        .WithMany("DestinationPoints")
                        .HasForeignKey("DestinationPointId")
                        .HasConstraintName("DestinationPoint_FK")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("SmartRides.Models.Entities.Location", "StartPoint")
                        .WithMany("StartPoints")
                        .HasForeignKey("StartPointId")
                        .HasConstraintName("StartPoint_FK")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("DestinationPoint");

                    b.Navigation("StartPoint");
                });

            modelBuilder.Entity("SmartRides.Models.Entities.RideDate", b =>
                {
                    b.HasOne("SmartRides.Models.Entities.Ride", "Ride")
                        .WithMany("RideDates")
                        .HasForeignKey("RideId")
                        .HasConstraintName("RideDate_Ride_FK")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Ride");
                });

            modelBuilder.Entity("SmartRides.Models.Entities.RideSchedule", b =>
                {
                    b.HasOne("SmartRides.Models.Entities.RideDate", "RideDate")
                        .WithMany("RideSchedules")
                        .HasForeignKey("RideDateId")
                        .HasConstraintName("RideDate_FK")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("SmartRides.Models.Entities.Schedule", "Schedule")
                        .WithMany("RideSchedules")
                        .HasForeignKey("ScheduleId")
                        .HasConstraintName("Schedule_FK")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("RideDate");

                    b.Navigation("Schedule");
                });

            modelBuilder.Entity("SmartRides.Models.Entities.RideStop", b =>
                {
                    b.HasOne("SmartRides.Models.Entities.Location", "Location")
                        .WithMany("RideStops")
                        .HasForeignKey("LocationId")
                        .HasConstraintName("Location_FK")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("SmartRides.Models.Entities.Ride", "Ride")
                        .WithMany("RideStops")
                        .HasForeignKey("RideId")
                        .HasConstraintName("Ride_FK")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Location");

                    b.Navigation("Ride");
                });

            modelBuilder.Entity("SmartRides.Models.Entities.Ticket", b =>
                {
                    b.HasOne("SmartRides.Models.Entities.User", "Customer")
                        .WithMany("Tickets")
                        .HasForeignKey("CustomerId")
                        .HasConstraintName("Customer_FK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SmartRides.Models.Entities.DiscountReason", "DiscountReason")
                        .WithMany("Tickets")
                        .HasForeignKey("DiscountReasonId")
                        .HasConstraintName("DiscountReason_FK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SmartRides.Models.Entities.TicketClassAttribute", "TicketClassAttribute")
                        .WithMany("Tickets")
                        .HasForeignKey("TicketClassAttributeId")
                        .HasConstraintName("TicketClassAttribute_FK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("DiscountReason");

                    b.Navigation("TicketClassAttribute");
                });

            modelBuilder.Entity("SmartRides.Models.Entities.TicketSeat", b =>
                {
                    b.HasOne("SmartRides.Models.Entities.Seat", "Seat")
                        .WithMany()
                        .HasForeignKey("SeatId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SmartRides.Models.Entities.Ticket", "Ticket")
                        .WithMany("Seats")
                        .HasForeignKey("TicketId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Seat");

                    b.Navigation("Ticket");
                });

            modelBuilder.Entity("SmartRides.Models.Entities.Bus", b =>
                {
                    b.Navigation("AvailableSeats");

                    b.Navigation("Driver");
                });

            modelBuilder.Entity("SmartRides.Models.Entities.DiscountReason", b =>
                {
                    b.Navigation("Tickets");
                });

            modelBuilder.Entity("SmartRides.Models.Entities.Location", b =>
                {
                    b.Navigation("DestinationPoints");

                    b.Navigation("RideStops");

                    b.Navigation("StartPoints");
                });

            modelBuilder.Entity("SmartRides.Models.Entities.Ride", b =>
                {
                    b.Navigation("RideDates");

                    b.Navigation("RideStops");
                });

            modelBuilder.Entity("SmartRides.Models.Entities.RideDate", b =>
                {
                    b.Navigation("RideSchedules");
                });

            modelBuilder.Entity("SmartRides.Models.Entities.RideSchedule", b =>
                {
                    b.Navigation("AvailableSeats");
                });

            modelBuilder.Entity("SmartRides.Models.Entities.Schedule", b =>
                {
                    b.Navigation("RideSchedules");
                });

            modelBuilder.Entity("SmartRides.Models.Entities.Seat", b =>
                {
                    b.Navigation("AvailableSeats");
                });

            modelBuilder.Entity("SmartRides.Models.Entities.Ticket", b =>
                {
                    b.Navigation("Seats");
                });

            modelBuilder.Entity("SmartRides.Models.Entities.TicketClassAttribute", b =>
                {
                    b.Navigation("Tickets");
                });

            modelBuilder.Entity("SmartRides.Models.Entities.User", b =>
                {
                    b.Navigation("Tickets");
                });
#pragma warning restore 612, 618
        }
    }
}