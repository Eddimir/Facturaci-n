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
    
    public partial class OrdenCompra
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OrdenCompra()
        {
            this.OrdenCompraDetalle = new HashSet<OrdenCompraDetalle>();
        }
    
        public int Id { get; set; }
        public Nullable<int> IdUsuario { get; set; }
        public Nullable<int> IdProveedor { get; set; }
        public string Observaciones { get; set; }
        public Nullable<decimal> Total { get; set; }
        public Nullable<System.DateTime> Fecha { get; set; }
    
        public virtual Proveedores Proveedores { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrdenCompraDetalle> OrdenCompraDetalle { get; set; }
        public virtual Usuarios Usuarios { get; set; }
    }
}
