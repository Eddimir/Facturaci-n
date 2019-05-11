//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class Productos
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Productos()
        {
            this.FacturacionDetalle = new HashSet<FacturacionDetalle>();
            this.OrdenCompraDetalle = new HashSet<OrdenCompraDetalle>();
        }
    
        public int Id { get; set; }
        public Nullable<int> IdCategoria { get; set; }
        public string Codigo { get; set; }
        public string Producto { get; set; }
        public decimal Precio { get; set; }
        public decimal Cantidad_Existencia { get; set; }
        public Nullable<decimal> ITBS { get; set; }
        public Nullable<decimal> Margen_Beneficio { get; set; }
        public string Despcricion { get; set; }
        public Nullable<System.DateTime> Registro { get; set; }
        public Nullable<System.DateTime> FechaVencimiento { get; set; }
        public Nullable<bool> AvisarVencimiento { get; set; }
        public Nullable<int> DiasParaAvisar { get; set; }
        public byte[] Imagen { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FacturacionDetalle> FacturacionDetalle { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrdenCompraDetalle> OrdenCompraDetalle { get; set; }
        public virtual ProductosCategoria ProductosCategoria { get; set; }
    }
}
