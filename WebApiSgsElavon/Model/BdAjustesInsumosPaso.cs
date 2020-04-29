using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_AJUSTES_INSUMOS_PASO")]
    public partial class BdAjustesInsumosPaso
    {
        [Column("ID_AJUSTE")]
        public int IdAjuste { get; set; }
        [Column("ID_BD_INSUMO")]
        public int? IdBdInsumo { get; set; }
        [Column("ENTRADA")]
        public int? Entrada { get; set; }
        [Column("SALIDA_ANTERIOR")]
        public int? SalidaAnterior { get; set; }
        [Column("SALIDA_ACTUAL")]
        public int? SalidaActual { get; set; }
        [Column("TOTAL")]
        public int? Total { get; set; }
        [Column("ID_USUARIO")]
        public int? IdUsuario { get; set; }
        [Column("ID_RESPONSABLE")]
        public int? IdResponsable { get; set; }
        [Column("ID_TIPO_RESPONSABLE")]
        public int? IdTipoResponsable { get; set; }
        [Column("FEC_ALTA", TypeName = "datetime")]
        public DateTime? FecAlta { get; set; }
    }
}
