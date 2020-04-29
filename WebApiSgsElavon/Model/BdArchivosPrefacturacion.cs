using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_ARCHIVOS_PREFACTURACION")]
    public partial class BdArchivosPrefacturacion
    {
        [Key]
        [Column("ID_ARCHIVO_PREFACTURACION")]
        public int IdArchivoPrefacturacion { get; set; }
        [Column("ID_AR_PREFACTURACION")]
        public int? IdArPrefacturacion { get; set; }
        [Column("ID_STATUS_CARGA_ARCHIVO_PREFACTURACION")]
        public int? IdStatusCargaArchivoPrefacturacion { get; set; }
        [Column("NOMBRE_ARCHIVO_PREFACTURACION_SYSTEM")]
        [StringLength(250)]
        public string NombreArchivoPrefacturacionSystem { get; set; }
        [Column("NOMBRE_ARCHIVO_PREFACTURACION_USER")]
        [StringLength(250)]
        public string NombreArchivoPrefacturacionUser { get; set; }
        [Column("ID_USUARIO_ALTA")]
        public int? IdUsuarioAlta { get; set; }
        [Column("FEC_ALTA", TypeName = "smalldatetime")]
        public DateTime? FecAlta { get; set; }
    }
}
