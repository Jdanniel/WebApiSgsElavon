using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_COMPROBACION_VIATICOS")]
    public partial class BdComprobacionViaticos
    {
        [Key]
        [Column("ID_COMPROBACION_VIATICOS")]
        public int IdComprobacionViaticos { get; set; }
        [Column("ID_SOLICITUD_VIATICOS")]
        public int IdSolicitudViaticos { get; set; }
        [Column("MONTO_COMPROBADO", TypeName = "numeric(18, 2)")]
        public decimal? MontoComprobado { get; set; }
        [Column("ARCHIVO_PDF")]
        [StringLength(100)]
        public string ArchivoPdf { get; set; }
        [Column("ARCHIVO_XML")]
        [StringLength(100)]
        public string ArchivoXml { get; set; }
        [Column("ESTATUS")]
        [StringLength(20)]
        public string Estatus { get; set; }
        [Column("MONTO_APROBADO", TypeName = "numeric(18, 2)")]
        public decimal? MontoAprobado { get; set; }
        [Column("STATUS")]
        public int? Status { get; set; }
        [Column("ID_RAZON")]
        public int? IdRazon { get; set; }
        [Column("ID_TIPO_VIATICO")]
        public int? IdTipoViatico { get; set; }
    }
}
