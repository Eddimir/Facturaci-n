﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Proyecto1.DataADO
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Proyecto1Entities : DbContext
    {
        public Proyecto1Entities()
            : base("name=Proyecto1Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Modulos> Modulos { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Almacen> Almacen { get; set; }
        public virtual DbSet<AlmacenMovimiento> AlmacenMovimiento { get; set; }
        public virtual DbSet<Puestos> Puestos { get; set; }
        public virtual DbSet<ConfiguracionEmpresa> ConfiguracionEmpresa { get; set; }
        public virtual DbSet<FacturacionDetalle> FacturacionDetalle { get; set; }
        public virtual DbSet<CXC> CXC { get; set; }
        public virtual DbSet<Proveedores> Proveedores { get; set; }
        public virtual DbSet<Ciudades> Ciudades { get; set; }
        public virtual DbSet<ComprobantesImpuestos> ComprobantesImpuestos { get; set; }
        public virtual DbSet<Departamentos> Departamentos { get; set; }
        public virtual DbSet<Empresas> Empresas { get; set; }
        public virtual DbSet<TipoDePago> TipoDePago { get; set; }
        public virtual DbSet<AlmacenDetalle> AlmacenDetalle { get; set; }
        public virtual DbSet<OrdenCompra> OrdenCompra { get; set; }
        public virtual DbSet<Clientes> Clientes { get; set; }
        public virtual DbSet<ProductosCategoria> ProductosCategoria { get; set; }
        public virtual DbSet<Facturacion> Facturacion { get; set; }
        public virtual DbSet<Productos> Productos { get; set; }
        public virtual DbSet<Seguridad> Seguridad { get; set; }
        public virtual DbSet<vsModulosUsuarios> vsModulosUsuarios { get; set; }
        public virtual DbSet<Usuarios> Usuarios { get; set; }
        public virtual DbSet<vsFacturacionDetalles> vsFacturacionDetalles { get; set; }
        public virtual DbSet<TipoDeDivisa> TipoDeDivisa { get; set; }
        public virtual DbSet<Sueldos> Sueldos { get; set; }
        public virtual DbSet<OrdenCompraDetalle> OrdenCompraDetalle { get; set; }
        public virtual DbSet<Cotizacion> Cotizacion { get; set; }
        public virtual DbSet<CotizacionDetalle> CotizacionDetalle { get; set; }
    }
}