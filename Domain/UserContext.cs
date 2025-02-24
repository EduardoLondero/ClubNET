﻿using Domain.Model;
using Microsoft.EntityFrameworkCore;

namespace Domain
{
    public class userContext : DbContext
    {
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Localidad> Localidad { get; set; }
        public DbSet<Provincia> Provincia { get; set; }
        public DbSet<Membresia> Membresia { get; set; }
        public DbSet<Rol> Rol { get; set; }
        public DbSet<Deporte> Deporte { get; set; }
        public DbSet<Tipo_Membresia> Tipo_Membresia { get; set; }
        public DbSet<Membresia_deporte> Membresia_Deporte { get; set; }
        public DbSet<Pago> Pago { get; set; }
        internal userContext()
        {
            this.Database.EnsureCreated();
        }

        public userContext(DbContextOptions<userContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Membresia_deporte>()
                .HasKey(md => new { md.oMembresiaId, md.oDeporteId });

            modelBuilder.Entity<Membresia_deporte>()
                .HasOne(md => md.oMembresia)
                .WithMany(m => m.Membresias) 
                .HasForeignKey(md => md.oMembresiaId);

            modelBuilder.Entity<Membresia_deporte>()
                .HasOne(md => md.oDeporte)
                .WithMany(d => d.Membresias)
                .HasForeignKey(md => md.oDeporteId);
        }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>
            optionsBuilder.UseSqlServer("Server=KELSIER\\SQLEXPRESS;Database=Club;TrustServerCertificate=True;Integrated Security=True;", sqlOptions => sqlOptions.EnableRetryOnFailure());

    }
}