using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_BITACORA_NO_INSUMO_AR")]
    public partial class BdBitacoraNoInsumoAr
    {
        [Column("ID_BITACORA_NO_INSUMO_AR")]
        public int IdBitacoraNoInsumoAr { get; set; }
        [Column("ID_AR")]
        public int? IdAr { get; set; }
        [Column("ID_INSUMO")]
        public int? IdInsumo { get; set; }
        [Column("ID_TECNICO")]
        public int? IdTecnico { get; set; }
        [Column("CAUSA")]
        [StringLength(255)]
        public string Causa { get; set; }
        [Column("FEC_ALTA", TypeName = "datetime")]
        public DateTime? FecAlta { get; set; }
    }
}
