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
    
    public partial class Seguridad
    {
        public int id { get; set; }
        public int IdUsuario { get; set; }
        public int IdModulo { get; set; }
        public Nullable<bool> Editar { get; set; }
        public Nullable<bool> Ver { get; set; }
    
        public virtual Modulos Modulos { get; set; }
        public virtual Usuarios Usuarios { get; set; }
    }
}
