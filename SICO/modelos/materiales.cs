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
    
    public partial class materiales
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public materiales()
        {
            this.materiales_has_compras = new HashSet<materiales_has_compras>();
            this.productos_has_materiales = new HashSet<productos_has_materiales>();
        }
    
        public int id_material { get; set; }
        public int id_tipo_material { get; set; }
        public int id_unidad_medida { get; set; }
        public string nombre_material { get; set; }
        public decimal costo_material { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<materiales_has_compras> materiales_has_compras { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<productos_has_materiales> productos_has_materiales { get; set; }
        public virtual tipos_de_material tipos_de_material { get; set; }
        public virtual unidades_de_medida unidades_de_medida { get; set; }
    }
}
