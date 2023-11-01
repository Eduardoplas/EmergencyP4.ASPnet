using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Emergency;

public partial class Emergencyp4Context : DbContext
{
    public Emergencyp4Context()
    {
    }

    public Emergencyp4Context(DbContextOptions<Emergencyp4Context> options)
        : base(options)
    {
    }

    public virtual DbSet<Usuario> Usuarios { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseMySql("server=localhost;user=root;password=Ceoceo77;database=emergencyp4", ServerVersion.AutoDetect("server=localhost;user=root;password=Ceoceo77;database=emergencyp4"));

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .UseCollation("utf8mb4_0900_ai_ci")
            .HasCharSet("utf8mb4");

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("usuario");

            entity.Property(e => e.Alergias)
                .HasMaxLength(255)
                .HasColumnName("alergias");
            entity.Property(e => e.Altura).HasColumnName("altura");
            entity.Property(e => e.Clave)
                .HasMaxLength(255)
                .HasColumnName("clave");
            entity.Property(e => e.Correo)
                .HasMaxLength(255)
                .HasColumnName("correo");
            entity.Property(e => e.Edad).HasColumnName("edad");
            entity.Property(e => e.Enfermedad)
                .HasMaxLength(255)
                .HasColumnName("enfermedad");
            entity.Property(e => e.Materno)
                .HasMaxLength(255)
                .HasColumnName("materno");
            entity.Property(e => e.Nombre)
                .HasMaxLength(255)
                .HasColumnName("nombre");
            entity.Property(e => e.Otro)
                .HasMaxLength(25)
                .HasColumnName("otro");
            entity.Property(e => e.Paterno)
                .HasMaxLength(255)
                .HasColumnName("paterno");
            entity.Property(e => e.Peso).HasColumnName("peso");
            entity.Property(e => e.Telefono)
                .HasMaxLength(255)
                .HasColumnName("telefono");
            entity.Property(e => e.TelefonoEmergencias)
                .HasMaxLength(255)
                .HasColumnName("telefonoEmergencias");
            entity.Property(e => e.Tutor)
                .HasMaxLength(25)
                .HasColumnName("tutor");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
