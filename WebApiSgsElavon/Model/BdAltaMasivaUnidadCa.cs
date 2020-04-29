using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_ALTA_MASIVA_UNIDAD_CA")]
    public partial class BdAltaMasivaUnidadCa
    {
        [Column("ID_UNIDAD_CA")]
        public int IdUnidadCa { get; set; }
        [Column("ID_CARGA")]
        public int? IdCarga { get; set; }
        [Column("NO_SERIE")]
        [StringLength(250)]
        public string NoSerie { get; set; }
        [Column("ID_MODELO")]
        public int? IdModelo { get; set; }
        [Column("ID_CONECTIVIDAD")]
        public int? IdConectividad { get; set; }
        [Column("ID_APLICATIVO")]
        public int? IdAplicativo { get; set; }
        [Column("ID_USUARIO")]
        public int? IdUsuario { get; set; }
        [Column("STATUS")]
        [StringLength(50)]
        public string Status { get; set; }
        [Column("ERROR")]
        [StringLength(250)]
        public string Error { get; set; }
    }
}
