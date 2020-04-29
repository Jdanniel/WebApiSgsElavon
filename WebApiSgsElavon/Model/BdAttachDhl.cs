using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_ATTACH_DHL")]
    public partial class BdAttachDhl
    {
        [Column("ID_ATTACH_DHL")]
        public int IdAttachDhl { get; set; }
        [Column("NO_FACTURA")]
        [StringLength(255)]
        public string NoFactura { get; set; }
        [Column("ID_CARGA")]
        public int? IdCarga { get; set; }
        [Column("NOMBRE_ARCHIVO_USUARIO")]
        [StringLength(255)]
        public string NombreArchivoUsuario { get; set; }
        [Column("NOMBRE_ARCHIVO_SISTEMA")]
        [StringLength(255)]
        public string NombreArchivoSistema { get; set; }
        [Column("ID_USUARIO_ALTA")]
        public int? IdUsuarioAlta { get; set; }
        [Column("FEC_ALTA", TypeName = "datetime")]
        public DateTime? FecAlta { get; set; }
    }
}
