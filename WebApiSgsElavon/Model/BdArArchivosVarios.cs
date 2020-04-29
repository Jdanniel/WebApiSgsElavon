using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_AR_ARCHIVOS_VARIOS")]
    public partial class BdArArchivosVarios
    {
        [Key]
        [Column("ID_AR_ARCHIVO_VARIOS")]
        public int IdArArchivoVarios { get; set; }
        [Column("ID_AR")]
        public int IdAr { get; set; }
        [Column("NOMBRE_ARCHIVO_SISTEMA")]
        [StringLength(255)]
        public string NombreArchivoSistema { get; set; }
        [Column("NOMBRE_ARCHIVO_USUARIO")]
        [StringLength(255)]
        public string NombreArchivoUsuario { get; set; }
        [Column("RUTA")]
        [StringLength(500)]
        public string Ruta { get; set; }
        [Column("ID_TIPO_ARCHIVO")]
        public int? IdTipoArchivo { get; set; }
        [Column("ID_USUARIO_ALTA")]
        public int? IdUsuarioAlta { get; set; }
        [Column("FECHA_ALTA", TypeName = "smalldatetime")]
        public DateTime? FechaAlta { get; set; }
        [Column("ID_USUARIO_STATUS")]
        public int? IdUsuarioStatus { get; set; }
        [Column("FECHA_STATUS", TypeName = "smalldatetime")]
        public DateTime? FechaStatus { get; set; }
        [Column("STATUS")]
        [StringLength(50)]
        public string Status { get; set; }
    }
}
