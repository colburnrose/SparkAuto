using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SparkAuto.Models;

namespace SparkAuto.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }

        public virtual DbSet<ServiceType> ServiceTypes { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ServiceType>(entity =>
            {
                entity.ToTable("ServiceType")
                    .HasKey(e => e.Id);

                entity.Property(e => e.ServiceName)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.ServicePrice)
                    .IsRequired()
                    .IsUnicode(false);
            });

        }

    }
}
