//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SICO.modelos
{
    using System;
    using System.Collections.Generic;
    
    public partial class productos_has_cotizaciones
    {
        public int id_producto { get; set; }
        public int id_cotizacion { get; set; }
        public int cantidad { get; set; }
        public decimal costo_producto { get; set; }
    
        public virtual cotizaciones cotizaciones { get; set; }
        public virtual productos productos { get; set; }
    }
}
