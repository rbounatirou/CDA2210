using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WinFormsMultiCouche.Models;

public partial class DbJeuContext : DbContext
{
    public DbJeuContext()
    {
    }

    public DbJeuContext(DbContextOptions<DbJeuContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Compte> Comptes { get; set; }

    public virtual DbSet<Personnage> Personnages { get; set; }

    public virtual DbSet<Race> Races { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=CRM-UC-3625\\SQLEXPRESS2;User ID=jeu;Password=1234;Database=DbJeu;Trusted_Connection=False;TrustServerCertificate=true");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Compte>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__comptes__3213E83F528E53A6");

            entity.ToTable("comptes");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Pseudo)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("pseudo");
        });

        modelBuilder.Entity<Personnage>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__personna__3213E83FD4AEFF3B");

            entity.ToTable("personnages");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CharacterName)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("characterName");
            entity.Property(e => e.IdCompte).HasColumnName("idCompte");
            entity.Property(e => e.IdRace).HasColumnName("idRace");

            entity.HasOne(d => d.IdCompteNavigation).WithMany(p => p.Personnages)
                .HasForeignKey(d => d.IdCompte)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_personnages_idcompte");

            entity.HasOne(d => d.IdRaceNavigation).WithMany(p => p.Personnages)
                .HasForeignKey(d => d.IdRace)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_personnages_idrace");
        });

        modelBuilder.Entity<Race>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__races__3213E83F40468B0D");

            entity.ToTable("races");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Nom)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("nom");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
