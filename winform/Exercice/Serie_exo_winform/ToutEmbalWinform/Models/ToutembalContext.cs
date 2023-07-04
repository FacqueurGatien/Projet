using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ToutEmbalWinform.Models;

public partial class ToutembalContext : DbContext
{
    public ToutembalContext()
    {
    }

    public ToutembalContext(DbContextOptions<ToutembalContext> options)
        : base(options)
    {
    }

    public virtual DbSet<CaisseSQL> Caisses { get; set; }

    public virtual DbSet<ProductionSQL> ProductionSQL { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=SHADOW-DLSO609M;User ID=sa;Password=Tsubasa1234.;Database=Toutembal;Trusted_Connection=False;TrustServerCertificate=true");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<CaisseSQL>(entity =>
        {
            entity.HasKey(e => e.CaisseId).HasName("PK__Caisse__4AA69F8571420A18");

            entity.ToTable("Caisse");

            entity.Property(e => e.CaisseId).HasColumnName("caisseId");
            entity.Property(e => e.CaisseNom)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("caisseNom");
            entity.Property(e => e.CaisseValid).HasColumnName("caisseValid");
            entity.Property(e => e.CaisseVitesseHeure).HasColumnName("caisseVitesseHeure");
            entity.Property(e => e.ProdId).HasColumnName("prodId");

            entity.HasOne(d => d.Prod).WithMany(p => p.Caisses)
                .HasForeignKey(d => d.ProdId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Caisse__prodId__55F4C372");
        });

        modelBuilder.Entity<ProductionSQL>(entity =>
        {
            entity.HasKey(e => e.ProdId).HasName("PK__Producti__319F67F1A507F6AB");

            entity.ToTable("Production");

            entity.Property(e => e.ProdId).HasColumnName("prodId");
            entity.Property(e => e.ProdNom)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("prod_Nom");
            entity.Property(e => e.ProdObjectif).HasColumnName("prodObjectif");
            entity.Property(e => e.ProductionCaisseTauxDefaut)
                .HasColumnType("decimal(5, 2)")
                .HasColumnName("productionCaisseTauxDefaut");
        });

        OnModelCreatingPartial(modelBuilder);
    }
    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
