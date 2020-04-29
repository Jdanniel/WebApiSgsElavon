using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_USUARIO_ARCHIVOS_VARIOS")]
    public partial class BdUsuarioArchivosVarios
    {
        [Key]
        [Column("ID_USUARIO_ARCHIVOS_VARIOS")]
        public int IdUsuarioArchivosVarios { get; set; }
        [Column("ID_USUARIO")]
        public int? IdUsuario { get; set; }
        [Column("NOMBRE_ARCHIVO_SISTEMA")]
        [StringLength(300)]
        public string NombreArchivoSistema { get; set; }
        [Column("NOMBRE_ARCHIVO_USUARIO")]
        [StringLength(300)]
        public string NombreArchivoUsuario { get; set; }
        [Column("RUTA")]
        [StringLength(300)]
        public string Ruta { get; set; }
        [Column("ID_TIPO_ARCHIVO")]
        public int? IdTipoArchivo { get; set; }
        [Column("ID_USUARIO_ALTA")]
        public int? IdUsuarioAlta { get; set; }
        [Column("FECHA_ALTA", TypeName = "smalldatetime")]
        public DateTime? FechaAlta { get; set; }
        [Column("FECHA_STATUS", TypeName = "smalldatetime")]
        public DateTime? FechaStatus { get; set; }
        [Column("STATUS")]
        [StringLength(100)]
        public string Status { get; set; }
    }
}
