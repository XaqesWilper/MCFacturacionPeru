namespace CapaEntidad
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ce_tm_Cliente
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ce_tm_Cliente()
        {
            co_cabFactura = new HashSet<ce_co_cabFactura>();
        }

        [Key]
        public int id_tmc_Cliente { get; set; }

        [StringLength(100)]
        public string ds_tmc_Cliente { get; set; }

        [StringLength(12)]
        public string tmc_ruc { get; set; }

        [StringLength(100)]
        public string tmc_Direccion { get; set; }

        public DateTime? tmc_FechaRegistro { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ce_co_cabFactura> co_cabFactura { get; set; }
    }
}
