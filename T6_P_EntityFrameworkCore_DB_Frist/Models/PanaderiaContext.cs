using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace T6_P_EntityFrameworkCore_DB_Frist.Models;

public partial class PanaderiaContext : DbContext
{
    public PanaderiaContext()
    {
    }

    public PanaderiaContext(DbContextOptions<PanaderiaContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Producto> Productos { get; set; }

    public virtual DbSet<Panaderia> Panaderias { get; set; }

    public virtual DbSet<PanaderiaProducto> PanaderiasProductos { get; set; }


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=localhost;Database=Panaderia;Trusted_Connection=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Panaderia>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Panaderi__3214EC074485356F");

            entity.Property(e => e.Direccion).HasMaxLength(200);
            entity.Property(e => e.Nombre).HasMaxLength(100);
            entity.Property(e => e.Telefono).HasMaxLength(12);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
