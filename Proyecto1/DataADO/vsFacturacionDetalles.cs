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
    
    public partial class vsFacturacionDetalles
    {
        public Nullable<System.DateTime> Fecha { get; set; }
        public string Producto { get; set; }
        public Nullable<decimal> Cantidad { get; set; }
        public Nullable<int> IdProducto { get; set; }
        public Nullable<int> idUsario { get; set; }
        public Nullable<decimal> Total { get; set; }
        public Nullable<bool> Cerrada { get; set; }
        public Nullable<int> idCliente { get; set; }
        public string Observaciones { get; set; }
        public int Id { get; set; }
        public Nullable<System.DateTime> FechaVencimiento { get; set; }
        public Nullable<System.DateTime> FechaAnulacion { get; set; }
        public Nullable<bool> pagada { get; set; }
        public string DetalleTipoDepago { get; set; }
        public Nullable<decimal> ITBIS { get; set; }
        public Nullable<decimal> Descuento { get; set; }
        public Nullable<decimal> Precio { get; set; }
        public Nullable<decimal> Impuesto { get; set; }
        public string DescripcionImpuesto { get; set; }
        public Nullable<int> IdFacturacion { get; set; }
        public Nullable<bool> AvisarVencimiento { get; set; }
        public Nullable<decimal> Margen_Beneficio { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Celular { get; set; }
        public string Correo { get; set; }
        public string Cedula { get; set; }
        public string TipoDePago { get; set; }
        public string TipoDivisa { get; set; }
    }
}
