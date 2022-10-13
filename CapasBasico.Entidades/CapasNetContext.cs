using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace CapasBasico.Entidades
{
    public partial class CapasNetContext : DbContext
    {
        public CapasNetContext()
        {
        }

        public CapasNetContext(DbContextOptions<CapasNetContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Cargo> Cargos { get; set; } = null!;
        public virtual DbSet<Personal> Personals { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cargo>(entity =>
            {
                entity.ToTable("Cargo");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(100)
                    .HasColumnName("descripcion");

                entity.Property(e => e.Estado).HasColumnName("estado");
            });

            modelBuilder.Entity<Personal>(entity =>
            {
                entity.HasKey(e => e.NumeroDocumento);

                entity.ToTable("Personal");

                entity.Property(e => e.NumeroDocumento)
                    .HasMaxLength(8)
                    .HasColumnName("numero_documento");

                entity.Property(e => e.Apellidos)
                    .HasMaxLength(50)
                    .HasColumnName("apellidos");

                entity.Property(e => e.Edad).HasColumnName("edad");

                entity.Property(e => e.FechaNacimiento)
                    .HasColumnType("date")
                    .HasColumnName("fecha_nacimiento");

                entity.Property(e => e.IdCargo).HasColumnName("id_cargo");

                entity.Property(e => e.Nombres)
                    .HasMaxLength(50)
                    .HasColumnName("nombres");

                entity.HasOne(d => d.IdCargoNavigation)
                    .WithMany(p => p.Personals)
                    .HasForeignKey(d => d.IdCargo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Personal_Cargo");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
