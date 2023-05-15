﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Lange_Final_API.Models;

namespace Lange_Final_API.Data
{
    public partial class DMV_DatabaseContext : DbContext
    {
        public DMV_DatabaseContext()
        {
        }

        public DMV_DatabaseContext(DbContextOptions<DMV_DatabaseContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Driver> Drivers { get; set; }
        public virtual DbSet<DriversInfraction> DriversInfractions { get; set; }
        public virtual DbSet<DriversVehicle> DriversVehicles { get; set; }
        public virtual DbSet<Infraction> Infractions { get; set; }
        public virtual DbSet<Vehicle> Vehicles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Driver>(entity =>
            {
                entity.HasKey(e => e.DriverLicenseNumber);

                entity.Property(e => e.DriverLicenseNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("driverLicenseNumber");

                entity.Property(e => e.DriverFirstName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("driverFirstName");

                entity.Property(e => e.DriverLastName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("driverLastName");

                entity.Property(e => e.DriverPhoneNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("driverPhoneNumber");

                entity.Property(e => e.DriverSocialSecurity)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("driverSocialSecurity");
            });

            modelBuilder.Entity<DriversInfraction>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.DriverLicenseNumber)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("driverLicenseNumber");

                entity.Property(e => e.InfractionId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("infractionID");
            });

            modelBuilder.Entity<DriversVehicle>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DriversVehicle");

                entity.Property(e => e.DriverLicenseNumber)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("driverLicenseNumber");

                entity.Property(e => e.VehicleLicensePlate)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("vehicleLicensePlate");
            });

            modelBuilder.Entity<Infraction>(entity =>
            {
                entity.HasKey(e => e.InfractionId);

                entity.Property(e => e.InfractionDate)
                    .HasColumnType("date")
                    .HasColumnName("infractionDate");

                entity.Property(e => e.InfractionFine)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("infractionFine");

                entity.Property(e => e.InfractionId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("infractionID");

                entity.Property(e => e.InfractionName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("infractionName");
            });

            modelBuilder.Entity<Vehicle>(entity =>
            {
                entity.HasKey(e => e.VehicleLicensePlate);

                entity.Property(e => e.VehicleColor)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("vehicleColor");

                entity.Property(e => e.VehicleLicensePlate)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("vehicleLicensePlate");

                entity.Property(e => e.VehicleMake)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("vehicleMake");

                entity.Property(e => e.VehicleModel)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("vehicleModel");

                entity.Property(e => e.VehicleVin)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("vehicleVIN");

                entity.Property(e => e.VehicleYear)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("vehicleYear");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}