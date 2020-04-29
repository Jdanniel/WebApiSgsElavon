using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_UNIVERSO_UNIDADES")]
    public partial class BdUniversoUnidades
    {
        [Key]
        [Column("ID_UNIVERSO_UNIDADES")]
        public int IdUniversoUnidades { get; set; }
        [Column("NO_SERIE")]
        [StringLength(30)]
        public string NoSerie { get; set; }
        [Column("MINOR_CATEGORY")]
        [StringLength(30)]
        public string MinorCategory { get; set; }
        [Column("ASSET_NUMBER")]
        [StringLength(20)]
        public string AssetNumber { get; set; }
        [Column("MAJOR_CATEGORY")]
        [StringLength(15)]
        public string MajorCategory { get; set; }
        [Column("FEC_ALTA", TypeName = "datetime")]
        public DateTime? FecAlta { get; set; }
        [Column("ID_USUARIO")]
        public int? IdUsuario { get; set; }
        [Column("STATUS")]
        [StringLength(10)]
        public string Status { get; set; }
        [Column("OBSERVACIONES", TypeName = "text")]
        public string Observaciones { get; set; }
        [Column("ID_PROCESO")]
        [StringLength(50)]
        public string IdProceso { get; set; }
        [Column("STATUS_CARGA")]
        [StringLength(20)]
        public string StatusCarga { get; set; }
    }
}
