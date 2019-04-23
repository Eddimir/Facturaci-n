//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Proyecto1.DataADO
{
    using System;
    using System.Collections.Generic;
    
    public partial class AlmacenMovimiento
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AlmacenMovimiento()
        {
            this.AlmacenDetalle = new HashSet<AlmacenDetalle>();
        }
    
        public int Id { get; set; }
        public int IdProveedor { get; set; }
        public int IdUsuarios { get; set; }
        public System.DateTime Fecha { get; set; }
        public string Observacion { get; set; }
        public decimal Total { get; set; }
    
        public virtual Proveedores Proveedores { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AlmacenDetalle> AlmacenDetalle { get; set; }
        public virtual Usuarios Usuarios { get; set; }
    }
}
