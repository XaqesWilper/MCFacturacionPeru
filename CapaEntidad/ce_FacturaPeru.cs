using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace CapaEntidad
{
    public partial class ce_FacturaPeru : DbContext
    {
        public ce_FacturaPeru()
            : base("name=FacturaPeru")
        {
        }

        public virtual DbSet<ce_co_cabFactura> co_cabFactura { get; set; }
        public virtual DbSet<ce_co_detFactura> co_detFactura { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<tm_Producto> tm_Producto { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ce_co_cabFactura>()
                .Property(e => e.cocf_doc_serie)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ce_co_cabFactura>()
                .Property(e => e.cocf_doc_tipo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ce_co_cabFactura>()
                .Property(e => e.cocf_doc_num)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ce_co_detFactura>()
                .Property(e => e.codf_CantUnidades)
                .HasPrecision(13, 2);

            modelBuilder.Entity<ce_co_detFactura>()
                .Property(e => e.codf_Precio)
                .HasPrecision(13, 2);

            modelBuilder.Entity<ce_co_detFactura>()
                .Property(e => e.codf_TotalIGV)
                .HasPrecision(13, 2);

            modelBuilder.Entity<ce_co_detFactura>()
                .Property(e => e.codf_Total)
                .HasPrecision(13, 2);

            modelBuilder.Entity<tm_Producto>()
                .Property(e => e.ds_tmp_Producto)
                .IsUnicode(false);

            modelBuilder.Entity<tm_Producto>()
                .Property(e => e.ds_tmp_Precio)
                .HasPrecision(10, 3);
        }
    }
}
