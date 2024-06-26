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
    
    public partial class empleados
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public empleados()
        {
            this.compras = new HashSet<compras>();
            this.productos = new HashSet<productos>();
        }
    
        public int id_empleado { get; set; }
        public int id_rol { get; set; }
        public string nombre_empleado { get; set; }
        public string apellidos_empleado { get; set; }
        public string nombre_usuario { get; set; }
        public string contrasena { get; set; }
        public string telefono_empleado { get; set; }
        public string correo_empleado { get; set; }
        public System.DateTime fecha_contratacion { get; set; }
        public System.DateTime fecha_actualizacion { get; set; }
        public int estado_empleado { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<compras> compras { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<productos> productos { get; set; }
        public virtual roles roles { get; set; }
    }
}
