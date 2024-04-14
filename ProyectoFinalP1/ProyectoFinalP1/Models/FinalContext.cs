using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ProyectoFinalP1.Models;

public partial class FinalContext : DbContext
{
    public FinalContext()
    {
    }

    public FinalContext(DbContextOptions<FinalContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Cliente> Clientes { get; set; }

    public virtual DbSet<Producto> Productos { get; set; }

    public virtual DbSet<Sucursale> Sucursales { get; set; }

    public virtual DbSet<Vendedore> Vendedores { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Cliente>(entity =>
        {
            entity.HasKey(e => e.IdCliente).HasName("PK__Clientes__FCE03992BA80119C");

            entity.Property(e => e.IdCliente).HasColumnName("Id_cliente");
            entity.Property(e => e.Apellido).HasColumnType("text");
            entity.Property(e => e.Cedula).HasColumnType("text");
            entity.Property(e => e.Correo).HasColumnType("text");
            entity.Property(e => e.Edad).HasColumnType("text");
            entity.Property(e => e.Nombre).HasColumnType("text");
            entity.Property(e => e.Telefono).HasColumnType("text");
        });

        modelBuilder.Entity<Producto>(entity =>
        {
            entity.HasKey(e => e.IdProductos).HasName("PK__Producto__2CB55F329A3EA5AE");

            entity.Property(e => e.IdProductos).HasColumnName("Id_productos");
            entity.Property(e => e.Categoria).HasColumnType("text");
            entity.Property(e => e.Descripcion).HasColumnType("text");
            entity.Property(e => e.Nombre).HasColumnType("text");
            entity.Property(e => e.Precio).HasColumnType("text");
            entity.Property(e => e.Stock)
                .HasColumnType("text")
                .HasColumnName("# Stock");
        });

        modelBuilder.Entity<Sucursale>(entity =>
        {
            entity.HasKey(e => e.IdSucursal).HasName("PK__Sucursal__A71B7D48592E80B9");

            entity.Property(e => e.IdSucursal).HasColumnName("Id_sucursal");
            entity.Property(e => e.Direccion).HasColumnType("text");
            entity.Property(e => e.Nombre).HasColumnType("text");
            entity.Property(e => e.Telefono).HasColumnType("text");
        });

        modelBuilder.Entity<Vendedore>(entity =>
        {
            entity.HasKey(e => e.IdVendedor).HasName("PK__Vendedor__5257D23D5C09A12F");

            entity.Property(e => e.IdVendedor).HasColumnName("Id_vendedor");
            entity.Property(e => e.Apellido).HasColumnType("text");
            entity.Property(e => e.Cedula).HasColumnType("text");
            entity.Property(e => e.Nombre).HasColumnType("text");
            entity.Property(e => e.Salario).HasColumnType("text");
            entity.Property(e => e.Telefono).HasColumnType("text");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
