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
    
    public partial class materiales_has_compras
    {
        public int id_material { get; set; }
        public int id_compra { get; set; }
        public int cantidad { get; set; }
        public int importe { get; set; }
    
        public virtual compras compras { get; set; }
        public virtual materiales materiales { get; set; }
    }
}
