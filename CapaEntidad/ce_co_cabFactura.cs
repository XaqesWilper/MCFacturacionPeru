namespace CapaEntidad
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ce_co_cabFactura
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ce_co_cabFactura()
        {
            co_detFactura = new HashSet<ce_co_detFactura>();
        }

        [Key]
        public int id_co_cabFactura { get; set; }

        [StringLength(4)]
        public string cocf_doc_serie { get; set; }

        [StringLength(2)]
        public string cocf_doc_tipo { get; set; }

        [StringLength(10)]
        public string cocf_doc_num { get; set; }

        public int? id_tmc_Cliente { get; set; }

        public DateTime? cocf_FechaRegistro { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ce_co_detFactura> co_detFactura { get; set; }
    }
}
