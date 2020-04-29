using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_INGRESO_ARCHIVOS_ASIGNACION")]
    public partial class BdIngresoArchivosAsignacion
    {
        [Key]
        [Column("ID_ARCHIVO_MASIVO")]
        public int IdArchivoMasivo { get; set; }
        [Column("ID_ARCHIVO")]
        public int? IdArchivo { get; set; }
        [Column("ID_AR")]
        public int? IdAr { get; set; }
        [Column("FEC_ATENCION", TypeName = "smalldatetime")]
        public DateTime? FecAtencion { get; set; }
        [Column("HORA_ATENCION")]
        [StringLength(5)]
        public string HoraAtencion { get; set; }
        [Column("ID_TECNICO")]
        public int? IdTecnico { get; set; }
        [Column("ID_DISPATCHER")]
        public int? IdDispatcher { get; set; }
        [Column("STATUS_ARCHIVO")]
        [StringLength(50)]
        public string StatusArchivo { get; set; }
        [Column("ID_USUARIO_ALTA_ARCHIVO")]
        public int? IdUsuarioAltaArchivo { get; set; }
        [Column("FECHA_ALTA_ARCHIVO", TypeName = "smalldatetime")]
        public DateTime? FechaAltaArchivo { get; set; }
        [Column("DESC_ERROR")]
        [StringLength(250)]
        public string DescError { get; set; }
    }
}
