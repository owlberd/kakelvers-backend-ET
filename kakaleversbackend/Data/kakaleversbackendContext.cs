using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using kakaleversbackend.Models;

namespace kakaleversbackend.Data
{
    public partial class kakaleversbackendContext : DbContext
    {
        public kakaleversbackendContext()
        {
        }

        public kakaleversbackendContext(DbContextOptions<kakaleversbackendContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Klant> Klants { get; set; } = null!;
        public virtual DbSet<Producten> Productens { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySql("name=kakelversDB", Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.31-mysql"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseCollation("utf8mb4_0900_ai_ci")
                .HasCharSet("utf8mb4");

            modelBuilder.Entity<Klant>(entity =>
            {
                entity.ToTable("klant");

                entity.Property(e => e.Achternaam).HasMaxLength(45);

                entity.Property(e => e.Email).HasMaxLength(45);

                entity.Property(e => e.LidSinds)
                    .HasMaxLength(45)
                    .HasColumnName("Lid_sinds");

                entity.Property(e => e.Naam).HasMaxLength(45);

                entity.Property(e => e.Telefoon).HasMaxLength(45);
            });

            modelBuilder.Entity<Producten>(entity =>
            {
                entity.ToTable("producten");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Ean).HasColumnName("ean");

                entity.Property(e => e.Eenheid)
                    .HasMaxLength(45)
                    .HasColumnName("eenheid");

                entity.Property(e => e.LeverancierId).HasColumnName("leverancier_id");

                entity.Property(e => e.MassaVolume)
                    .HasMaxLength(45)
                    .HasColumnName("massa_volume");

                entity.Property(e => e.ProductId).HasColumnName("product_id");

                entity.Property(e => e.ProductNaam)
                    .HasMaxLength(45)
                    .HasColumnName("product_naam");

                entity.Property(e => e.ProductOmschrijving)
                    .HasMaxLength(255)
                    .HasColumnName("product_omschrijving");

                entity.Property(e => e.Voedingswaarde)
                    .HasMaxLength(45)
                    .HasColumnName("voedingswaarde");

                entity.Property(e => e.Voorraad).HasColumnName("voorraad");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
