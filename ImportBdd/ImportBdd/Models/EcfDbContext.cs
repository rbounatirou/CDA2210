using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using Microsoft.EntityFrameworkCore;


namespace ImportBdd.Models;


public partial class EcfDbContext : DbContext
{
    public EcfDbContext()
    {
    }

    public EcfDbContext(DbContextOptions<EcfDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<ProductionDone> ProductionDones { get; set; }

    public virtual DbSet<ProductionLine> ProductionLines { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Data Source = CRM - UC - 3932\\SQLEXPRESS; Initial Catalog = ecf_db; User ID = sa; Password=Cdi1234;Trust Server Certificate=true");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(e => e.ProductId).HasName("PK__products__47027DF545240F86");

            entity.Property(e => e.ProductId).ValueGeneratedNever();
        });

        modelBuilder.Entity<ProductionDone>(entity =>
        {
            entity.HasKey(e => e.ForgeId).HasName("PK__producti__A1B658BC051F7412");

            entity.Property(e => e.ForgeId).ValueGeneratedNever();
            entity.Property(e => e.LineId).IsFixedLength();

            entity.HasOne(d => d.Line).WithMany(p => p.ProductionDones)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_line_id");

            entity.HasOne(d => d.Product).WithMany(p => p.ProductionDones)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_production_done_product_id");
        });

        modelBuilder.Entity<ProductionLine>(entity =>
        {
            entity.HasKey(e => e.LineId).HasName("PK__producti__F5AE5F629D26FC9F");

            entity.Property(e => e.LineId).IsFixedLength();

            entity.HasOne(d => d.Product).WithMany(p => p.ProductionLines)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_production_lines_product_id");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
