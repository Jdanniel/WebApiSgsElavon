using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_BITACORA_CONECTIVIDAD_UNIDAD")]
    public partial class BdBitacoraConectividadUnidad
    {
        [Column("ID_CONECTIVIDAD_UNIDAD")]
        public int IdConectividadUnidad { get; set; }
        [Column("ID_AR")]
        public int? IdAr { get; set; }
        [Column("ID_UNIDAD")]
        public int? IdUnidad { get; set; }
        [Column("ID_CONECTIVIDAD_VIEJA")]
        public int? IdConectividadVieja { get; set; }
        [Column("ID_CONECTIVIDAD_NUEVA")]
        public int? IdConectividadNueva { get; set; }
        [Column("ID_USUARIO_ALTA")]
        public int? IdUsuarioAlta { get; set; }
        [Column("FECHA_ALTA", TypeName = "datetime")]
        public DateTime? FechaAlta { get; set; }
    }
}
