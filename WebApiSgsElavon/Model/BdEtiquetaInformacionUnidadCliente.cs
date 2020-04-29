using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_ETIQUETA_INFORMACION_UNIDAD_CLIENTE")]
    public partial class BdEtiquetaInformacionUnidadCliente
    {
        [Key]
        [Column("ID_ETIQUETA_INFORMACION_UNIDAD_CLIENTE")]
        public int IdEtiquetaInformacionUnidadCliente { get; set; }
        [Column("ID_ETIQUETA_INFORMACION_UNIDAD")]
        public int? IdEtiquetaInformacionUnidad { get; set; }
        [Column("ID_CLIENTE")]
        public int? IdCliente { get; set; }
        [Column("DESC_ETIQUETA_INFORMACION_UNIDAD_CLIENTE")]
        [StringLength(250)]
        public string DescEtiquetaInformacionUnidadCliente { get; set; }
        [Column("ID_USUARIO_ALTA")]
        public int? IdUsuarioAlta { get; set; }
        [Column("FEC_ALTA", TypeName = "smalldatetime")]
        public DateTime? FecAlta { get; set; }
        [Column("STATUS")]
        [StringLength(50)]
        public string Status { get; set; }
    }
}
