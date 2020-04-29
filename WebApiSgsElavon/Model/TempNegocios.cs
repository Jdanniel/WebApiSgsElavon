using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("TEMP_NEGOCIOS")]
    public partial class TempNegocios
    {
        [Column("ID")]
        public int Id { get; set; }
        [Column("NO_AFILIACION")]
        [StringLength(255)]
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
        [Column("CP")]
        [StringLength(5)]
        public string Cp { get; set; }
        [Column("SEGMENTO")]
        [StringLength(255)]
        public string Segmento { get; set; }
        [Column("ID_REGION")]
        public int? IdRegion { get; set; }
        [Column("ID_ZONA")]
        public int? IdZona { get; set; }
        [Column("ID_SEGMENTO")]
        public int? IdSegmento { get; set; }
        [Column("ID_CLIENTE")]
        public int? IdCliente { get; set; }
        [Column("IS_DUPLICATED")]
        public int? IsDuplicated { get; set; }
        [Column("ID_ESTADO")]
        public int? IdEstado { get; set; }
    }
}
