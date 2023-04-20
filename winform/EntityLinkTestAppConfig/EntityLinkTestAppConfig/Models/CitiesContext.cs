using System;
using System.Collections.Generic;
using System.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace EntityLinkTestAppConfig.Models;

public partial class CitiesContext : DbContext
{
    public CitiesContext()
    {
    }

    public CitiesContext(DbContextOptions<CitiesContext> options)
        : base(options)
    {
    }

    public virtual DbSet<City> Cities { get; set; }

    public virtual DbSet<Country> Countries { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => ConfigDB(optionsBuilder);

    private void ConfigDB(DbContextOptionsBuilder dbb)
    {
        Configuration conf = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.PerUserRoaming);
        ConfigurationSection sect = conf.GetSection("connectionstrings");
        Encrypt(conf,sect);
        dbb.UseSqlServer(ConfigurationManager.ConnectionStrings["toto"].ConnectionString);
    }

    private void Encrypt(Configuration conf, ConfigurationSection sect)
    {
        if (sect != null && !sect.SectionInformation.IsProtected)
        {
            sect.SectionInformation.ProtectSection("DataProtectionConfigurationProvider");
            conf.Save();
        }
    }

    private void Decrypt(Configuration conf, ConfigurationSection sect){
        if (sect != null && sect.SectionInformation.IsProtected)
        {
            sect.SectionInformation.UnprotectSection();
            conf.Save();
        }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<City>(entity =>
        {
            entity.HasKey(e => e.CityId).HasName("PK__cities__031491A85B91470A");

            entity.ToTable("cities");

            entity.Property(e => e.CityId).HasColumnName("city_id");
            entity.Property(e => e.CityName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("city_name");
            entity.Property(e => e.CountryCode)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("country_code");

            entity.HasOne(d => d.CountryCodeNavigation).WithMany(p => p.Cities)
                .HasForeignKey(d => d.CountryCode)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_cities");
        });

        modelBuilder.Entity<Country>(entity =>
        {
            entity.HasKey(e => e.CountryCode).HasName("PK__countrie__3436E9A474F2ED51");

            entity.ToTable("countries");

            entity.Property(e => e.CountryCode)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("country_code");
            entity.Property(e => e.CountryName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("country_name");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
