﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using MedLifeDAL.Entities;

#nullable disable

namespace MedLifeDAL.Data
{
    public partial class MedlifeContext : DbContext
    {
        public MedlifeContext()
        {
        }

        public MedlifeContext(DbContextOptions<MedlifeContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AppRoleClaims> AppRoleClaims { get; set; }
        public virtual DbSet<AppRoles> AppRoles { get; set; }
        public virtual DbSet<AppUser> AppUser { get; set; }
        public virtual DbSet<AppUserClaims> AppUserClaims { get; set; }
        public virtual DbSet<AppUserLogins> AppUserLogins { get; set; }
        public virtual DbSet<AppUserRoles> AppUserRoles { get; set; }
        public virtual DbSet<AppUserTokens> AppUserTokens { get; set; }
        public virtual DbSet<AppoinmentBooking> AppoinmentBooking { get; set; }
        public virtual DbSet<Departments> Departments { get; set; }
        public virtual DbSet<Doctors> Doctors { get; set; }
        public virtual DbSet<HealthProblems> HealthProblems { get; set; }
        public virtual DbSet<Status> Status { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<AppRoleClaims>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AppRoleClaims)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__AppRoleCl__RoleI__36B12243");
            });

            modelBuilder.Entity<AppRoles>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Name).HasMaxLength(256);

                entity.Property(e => e.NormalizedName).HasMaxLength(256);
            });

            modelBuilder.Entity<AppUser>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Email).HasMaxLength(256);

                entity.Property(e => e.Gender)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.NormalizedEmail).HasMaxLength(256);

                entity.Property(e => e.NormalizedUserName).HasMaxLength(256);

                entity.Property(e => e.UserName).HasMaxLength(256);

                entity.Property(e => e.UserRole).HasMaxLength(50);
            });

            modelBuilder.Entity<AppUserClaims>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AppUserClaims)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__AppUserCl__UserI__398D8EEE");
            });

            modelBuilder.Entity<AppUserLogins>(entity =>
            {
                entity.HasKey(e => new { e.LoginProvider, e.ProviderKey })
                    .HasName("PK__AppUserL__2B2C5B52B71FDD77");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AppUserLogins)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__AppUserLo__UserI__2E1BDC42");
            });

            modelBuilder.Entity<AppUserRoles>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.RoleId })
                    .HasName("PK__AppUserR__AF2760ADC1DD789E");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AppUserRoles)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__AppUserRo__RoleI__2B3F6F97");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AppUserRoles)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__AppUserRo__UserI__2A4B4B5E");
            });

            modelBuilder.Entity<AppUserTokens>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.LoginProvider, e.Name })
                    .HasName("PK__AppUserT__8CC498416C9B4A6E");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AppUserTokens)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__AppUserTo__UserI__30F848ED");
            });

            modelBuilder.Entity<AppoinmentBooking>(entity =>
            {
                entity.Property(e => e.AppointmentOn).HasColumnType("datetime");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedAt).HasColumnType("datetime");

                entity.Property(e => e.Others)
                    .HasMaxLength(500)
                    .HasColumnName("others");

                entity.Property(e => e.Priscription).HasMaxLength(300);

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.AppoinmentBookingCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Appoinmen__Creat__6A30C649");

                entity.HasOne(d => d.Doctor)
                    .WithMany(p => p.AppoinmentBookingDoctor)
                    .HasForeignKey(d => d.DoctorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Appoinmen__Docto__66603565");

                entity.HasOne(d => d.HealthProblem)
                    .WithMany(p => p.AppoinmentBooking)
                    .HasForeignKey(d => d.HealthProblemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Appoinmen__Healt__6754599E");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.AppoinmentBookingModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy)
                    .HasConstraintName("FK__Appoinmen__Modif__6B24EA82");

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.AppoinmentBookingPatient)
                    .HasForeignKey(d => d.PatientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Appoinmen__Patie__656C112C");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.AppoinmentBooking)
                    .HasForeignKey(d => d.StatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Appoinmen__Statu__68487DD7");
            });

            modelBuilder.Entity<Departments>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<Doctors>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Image)
                    .IsRequired()
                    .HasMaxLength(300);

                entity.Property(e => e.ModifiedAt).HasColumnType("datetime");

                entity.Property(e => e.Qualification)
                    .IsRequired()
                    .HasMaxLength(300);

                entity.Property(e => e.UniqueImageName)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.DoctorsCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Doctors__Created__403A8C7D");

                entity.HasOne(d => d.Department)
                    .WithMany(p => p.Doctors)
                    .HasForeignKey(d => d.DepartmentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Doctors__Departm__3E52440B");

                entity.HasOne(d => d.IdNavigation)
                    .WithOne(p => p.DoctorsIdNavigation)
                    .HasForeignKey<Doctors>(d => d.Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Doctors__Id__3D5E1FD2");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.DoctorsModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy)
                    .HasConstraintName("FK__Doctors__Modifie__412EB0B6");
            });

            modelBuilder.Entity<HealthProblems>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(300);
            });

            modelBuilder.Entity<Status>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}