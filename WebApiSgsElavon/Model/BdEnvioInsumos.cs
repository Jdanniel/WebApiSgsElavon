using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_ENVIO_INSUMOS")]
    public partial class BdEnvioInsumos
    {
        [Key]
        [Column("ID_ENVIO_INSUMO")]
        public int IdEnvioInsumo { get; set; }
        [Column("ID_INSUMO")]
        public int? IdInsumo { get; set; }
        [Column("ID_ENVIO")]
        public int? IdEnvio { get; set; }
        [Column("CANTIDAD")]
        public int? Cantidad { get; set; }
        [Column("ID_TIPO_RESPONSABLE")]
        public int? IdTipoResponsable { get; set; }
        [Column("ID_RESPONSABLE")]
        public int? IdResponsable { get; set; }
        [Column("FECHA_ALTA", TypeName = "smalldatetime")]
        public DateTime? FechaAlta { get; set; }
        [Column("ID_USUARIO_ALTA")]
        public int? IdUsuarioAlta { get; set; }
        [Column("IS_RECIBIDA")]
        public int? IsRecibida { get; set; }
        [Column("FEC_RECIBIDA", TypeName = "smalldatetime")]
        public DateTime? FecRecibida { get; set; }
        [Column("ID_USUARIO_RECEPCION")]
        public int? IdUsuarioRecepcion { get; set; }
        [Column("ID_STATUS_UNIDAD2")]
        public int? IdStatusUnidad2 { get; set; }

        [ForeignKey("IdEnvio")]
        [InverseProperty("BdEnvioInsumos")]
        public virtual BdEnvios IdEnvioNavigation { get; set; }
    }
}
