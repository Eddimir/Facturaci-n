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
    
    public partial class Facturacion
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Facturacion()
        {
            this.FacturacionDetalle = new HashSet<FacturacionDetalle>();
        }
    
        public int Id { get; set; }
        public Nullable<int> idUsario { get; set; }
        public string Observaciones { get; set; }
        public Nullable<int> idCliente { get; set; }
        public decimal total { get; set; }
        public Nullable<bool> Cerrada { get; set; }
        public Nullable<System.DateTime> Fecha { get; set; }
    
        public virtual Clientes Clientes { get; set; }
        public virtual Usuarios Usuarios { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FacturacionDetalle> FacturacionDetalle { get; set; }
    }
}
