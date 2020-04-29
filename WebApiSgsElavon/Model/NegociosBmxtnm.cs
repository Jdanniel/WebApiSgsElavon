using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("NEGOCIOS_BMXTNM")]
    public partial class NegociosBmxtnm
    {
        [Column("ID")]
        public int Id { get; set; }
        [Column("ID_CLIENTE")]
        public int? IdCliente { get; set; }
        [Column("ID_REGION")]
        public int? IdRegion { get; set; }
        [Column("ID_ZONA")]
        public int? IdZona { get; set; }
        [Column("ID_SEGMENTO")]
        public double? IdSegmento { get; set; }
        [Column("NO_AFILIACION")]
        [StringLength(50)]
        public string NoAfiliacion { get; set; }
        [Column("DESC_NEGOCIO")]
        [StringLength(255)]
        public string DescNegocio { get; set; }
        [Column("DIRECCION")]
        [StringLength(255)]
        public string Direccion { get; set; }
        [Column("COLONIA")]
        [StringLength(255)]
        public string Colonia { get; set; }
        [Column("POBLACION")]
        [StringLength(255)]
        public string Poblacion { get; set; }
        [Column("ESTADO")]
        [StringLength(255)]
        public string Estado { get; set; }
        [Column("ID_ESTADO")]
        public int? IdEstado { get; set; }
        [Column("CP")]
        public double? Cp { get; set; }
        [Column("TELEFONO")]
        public double? Telefono { get; set; }
        [Column("IS_DUPLICATED")]
        public int? IsDuplicated { get; set; }
    }
}
