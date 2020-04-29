using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_BITACORA_INSUMOS")]
    public partial class BdBitacoraInsumos
    {
        [Column("ID_BITACORA_INSUMO")]
        public int IdBitacoraInsumo { get; set; }
        [Column("ID_INSUMO")]
        public int IdInsumo { get; set; }
        [Column("ID_STATUS_INSUMO_INI")]
        public int? IdStatusInsumoIni { get; set; }
        [Column("ID_STATUS_INSUMO_FIN")]
        public int? IdStatusInsumoFin { get; set; }
        [Column("ID_TIPO_RESPONSABLE")]
        public int? IdTipoResponsable { get; set; }
        [Column("ID_RESPONSABLE")]
        public int? IdResponsable { get; set; }
        [Column("ID_USUARIO_ALTA")]
        public int? IdUsuarioAlta { get; set; }
        [Column("FEC_ALTA", TypeName = "smalldatetime")]
        public DateTime? FecAlta { get; set; }

        [ForeignKey("IdStatusInsumoFin")]
        [InverseProperty("BdBitacoraInsumosIdStatusInsumoFinNavigation")]
        public virtual CStatusInsumos IdStatusInsumoFinNavigation { get; set; }
        [ForeignKey("IdStatusInsumoIni")]
        [InverseProperty("BdBitacoraInsumosIdStatusInsumoIniNavigation")]
        public virtual CStatusInsumos IdStatusInsumoIniNavigation { get; set; }
        [ForeignKey("IdTipoResponsable")]
        [InverseProperty("BdBitacoraInsumos")]
        public virtual CTipoResponsable IdTipoResponsableNavigation { get; set; }
    }
}
