using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("C_ARCHIVOS")]
    public partial class CArchivos
    {
        [Key]
        [Column("ID_ARCHIVO")]
        public int IdArchivo { get; set; }
        [Column("FECHA_ALTA", TypeName = "smalldatetime")]
        public DateTime? FechaAlta { get; set; }
        [Column("NOMBRE_ARCHIVO")]
        [StringLength(250)]
        public string NombreArchivo { get; set; }
        [Column("DESC_ARCHIVO")]
        public string DescArchivo { get; set; }
        [Column("IS_CERRADO_EXITO")]
        public int? IsCerradoExito { get; set; }
        [Column("STATUS")]
        [StringLength(50)]
        public string Status { get; set; }
        [Column("IS_ENVIO")]
        public int? IsEnvio { get; set; }
        [Column("IS_RECEPCION")]
        public int? IsRecepcion { get; set; }
        [Column("IS_ALMACEN_MASIVO")]
        public int? IsAlmacenMasivo { get; set; }
    }
}
