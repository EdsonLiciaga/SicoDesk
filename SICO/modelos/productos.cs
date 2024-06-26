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
    
    public partial class productos
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public productos()
        {
            this.productos_has_materiales = new HashSet<productos_has_materiales>();
            this.productos_has_cotizaciones = new HashSet<productos_has_cotizaciones>();
        }
    
        public int id_producto { get; set; }
        public int id_tipo_producto { get; set; }
        public int id_empleado { get; set; }
        public decimal alto { get; set; }
        public decimal ancho { get; set; }
        public int cantidad_producto { get; set; }
        public decimal costo_producto { get; set; }
    
        public virtual empleados empleados { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<productos_has_materiales> productos_has_materiales { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<productos_has_cotizaciones> productos_has_cotizaciones { get; set; }
        public virtual tipos_de_producto tipos_de_producto { get; set; }
    }
}
