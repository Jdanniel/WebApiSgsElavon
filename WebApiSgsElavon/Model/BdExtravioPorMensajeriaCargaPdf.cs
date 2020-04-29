using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_EXTRAVIO_POR_MENSAJERIA_CARGA_PDF")]
    public partial class BdExtravioPorMensajeriaCargaPdf
    {
        [Column("ID_REPARACION_CARGA_PDF")]
        public int IdReparacionCargaPdf { get; set; }
        [Column("ID_UNIDAD")]
        public int? IdUnidad { get; set; }
        [Column("ARCHIVO_USUARIO")]
        [StringLength(255)]
        public string ArchivoUsuario { get; set; }
        [Column("ARCHIVO_SISTEMA")]
        [StringLength(255)]
        public string ArchivoSistema { get; set; }
        [Column("ID_USUARIO_ALTA")]
        public int? IdUsuarioAlta { get; set; }
        [Column("FEC_ALTA", TypeName = "datetime")]
        public DateTime? FecAlta { get; set; }
        [Column("ID_CLIENTE")]
        public int? IdCliente { get; set; }
    }
}
