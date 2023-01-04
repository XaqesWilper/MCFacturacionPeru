namespace CapaEntidad
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tm_Producto
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tm_Producto()
        {
            co_detFactura = new HashSet<ce_co_detFactura>();
        }

        [Key]
        public int id_tmp_Producto { get; set; }

        [StringLength(50)]
        public string ds_tmp_Producto { get; set; }

        public decimal? ds_tmp_Precio { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ce_co_detFactura> co_detFactura { get; set; }
    }
}
