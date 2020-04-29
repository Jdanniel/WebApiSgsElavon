using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("C_VENDEDORES")]
    public partial class CVendedores
    {
        [Column("ID_VENDEDOR")]
        public int IdVendedor { get; set; }
        [Column("ARCHER_VENDOR_ID")]
        public int? ArcherVendorId { get; set; }
        [Column("DESC_VENDEDOR")]
        [StringLength(255)]
        public string DescVendedor { get; set; }
        [Column("RFC")]
        [StringLength(20)]
        public string Rfc { get; set; }
        [Column("DIRECCION")]
        [StringLength(255)]
        public string Direccion { get; set; }
        [Column("COLONIA")]
        [StringLength(255)]
        public string Colonia { get; set; }
        [Column("CIUDAD")]
        [StringLength(255)]
        public string Ciudad { get; set; }
        [Column("ESTADO")]
        [StringLength(255)]
        public string Estado { get; set; }
        [Column("CP")]
        [StringLength(10)]
        public string Cp { get; set; }
        [Column("FEC_ALTA", TypeName = "datetime")]
        public DateTime? FecAlta { get; set; }
        [Column("ID_USUARIO_ALTA")]
        public int? IdUsuarioAlta { get; set; }
        [Column("STATUS")]
        [StringLength(50)]
        public string Status { get; set; }
    }
}
