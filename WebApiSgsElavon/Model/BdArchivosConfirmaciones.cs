using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_ARCHIVOS_CONFIRMACIONES")]
    public partial class BdArchivosConfirmaciones
    {
        [Key]
        [Column("ID_ARCHIVO_CONFIRMACIONES")]
        public int IdArchivoConfirmaciones { get; set; }
        [Column("ID_CARGA_CONFIRMACIONES")]
        public int? IdCargaConfirmaciones { get; set; }
        [Column("NOMBRE_ARCHIVO_CONFIRMACIONES_SYSTEM")]
        [StringLength(250)]
        public string NombreArchivoConfirmacionesSystem { get; set; }
        [Column("NOMBRE_ARCHIVO_CONFIRMACIONES_USER")]
        [StringLength(250)]
        public string NombreArchivoConfirmacionesUser { get; set; }
        [Column("ID_USUARIO_ALTA")]
        public int? IdUsuarioAlta { get; set; }
        [Column("FEC_ALTA", TypeName = "smalldatetime")]
        public DateTime? FecAlta { get; set; }

        [ForeignKey("IdCargaConfirmaciones")]
        [InverseProperty("BdArchivosConfirmaciones")]
        public virtual BdCargasConfirmaciones IdCargaConfirmacionesNavigation { get; set; }
    }
}
