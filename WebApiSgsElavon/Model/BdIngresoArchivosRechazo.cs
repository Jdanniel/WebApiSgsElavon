using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_INGRESO_ARCHIVOS_RECHAZO")]
    public partial class BdIngresoArchivosRechazo
    {
        [Key]
        [Column("ID_ARCHIVO_MASIVO")]
        public int IdArchivoMasivo { get; set; }
        [Column("ID_ARCHIVO")]
        public int? IdArchivo { get; set; }
        [Column("ID_AR")]
        public int? IdAr { get; set; }
        [Column("ID_USUARIO")]
        public int? IdUsuario { get; set; }
        [Column("ID_CAUSA")]
        public int? IdCausa { get; set; }
        [Column("ID_SOLUCION")]
        public int? IdSolucion { get; set; }
        [Column("DESCRIPCION_TRABAJO")]
        public string DescripcionTrabajo { get; set; }
        [Column("FOLIO_SERVICIO")]
        public string FolioServicio { get; set; }
        [Column("OTORGANTE_VOBO")]
        public string OtorganteVobo { get; set; }
        [Column("FEC_CIERRE", TypeName = "smalldatetime")]
        public DateTime? FecCierre { get; set; }
        [Column("HORA_CIERRE")]
        [StringLength(2)]
        public string HoraCierre { get; set; }
        [Column("MINUTO_CIERRE")]
        [StringLength(2)]
        public string MinutoCierre { get; set; }
        [Column("AUTORIZACION_RECHAZO")]
        public string AutorizacionRechazo { get; set; }
        [Column("ID_CAUSA_RECHAZO")]
        public int? IdCausaRechazo { get; set; }
        [Column("ID_ESPECIFICA_CAUSA_RECHAZO")]
        public int? IdEspecificaCausaRechazo { get; set; }
        [Column("IS_COBRABLE")]
        public int? IsCobrable { get; set; }
        [Column("PRECIO", TypeName = "numeric(18, 2)")]
        public decimal? Precio { get; set; }
        [Column("STATUS_ARCHIVO")]
        public string StatusArchivo { get; set; }
        [Column("ID_USUARIO_ALTA_ARCHIVO")]
        public int? IdUsuarioAltaArchivo { get; set; }
        [Column("FECHA_ALTA_ARCHIVO", TypeName = "smalldatetime")]
        public DateTime? FechaAltaArchivo { get; set; }
        [Column("DESC_ERROR")]
        public string DescError { get; set; }
        [Column("IS_MOV")]
        public int? IsMov { get; set; }
        [Column("NO_SERIE_ENTRADA")]
        [StringLength(250)]
        public string NoSerieEntrada { get; set; }
        [Column("NO_SERIE_SALIDA")]
        public string NoSerieSalida { get; set; }
        [Column("STATUS_MOV")]
        public string StatusMov { get; set; }
        [Column("DESC_ERROR_MOV")]
        public string DescErrorMov { get; set; }
        [Column("NO_EQUIPO_MOV")]
        public string NoEquipoMov { get; set; }
        [Column("IS_DANIADA")]
        public int? IsDaniada { get; set; }
    }
}
