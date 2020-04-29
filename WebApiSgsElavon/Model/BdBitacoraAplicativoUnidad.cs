using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_BITACORA_APLICATIVO_UNIDAD")]
    public partial class BdBitacoraAplicativoUnidad
    {
        [Column("ID_APLICATIVO_UNIDAD")]
        public int IdAplicativoUnidad { get; set; }
        [Column("ID_AR")]
        public int? IdAr { get; set; }
        [Column("ID_UNIDAD")]
        public int? IdUnidad { get; set; }
        [Column("ID_APLICATIVO_VIEJO")]
        public int? IdAplicativoViejo { get; set; }
        [Column("ID_APLICATIVO_NUEVO")]
        public int? IdAplicativoNuevo { get; set; }
        [Column("ID_USUARIO_ALTA")]
        public int? IdUsuarioAlta { get; set; }
        [Column("FECHA_ALTA", TypeName = "datetime")]
        public DateTime? FechaAlta { get; set; }
    }
}
