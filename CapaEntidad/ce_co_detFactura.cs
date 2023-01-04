namespace CapaEntidad
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ce_co_detFactura
    {
        [Key]
        public int id_co_detFactura { get; set; }

        public int? id_co_cabFactura { get; set; }

        public int? id_tmp_Producto { get; set; }

        public decimal? codf_CantUnidades { get; set; }

        public decimal? codf_Precio { get; set; }

        public decimal? codf_TotalIGV { get; set; }

        public decimal? codf_Total { get; set; }

        public virtual ce_co_cabFactura co_cabFactura { get; set; }

        public virtual tm_Producto tm_Producto { get; set; }
    }
}
