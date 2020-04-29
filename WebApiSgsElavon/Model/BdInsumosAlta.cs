using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_INSUMOS_ALTA")]
    public partial class BdInsumosAlta
    {
        [Column("ID_INSUMOS_ALTA")]
        public int IdInsumosAlta { get; set; }
        [Column("ID_INSUMO")]
        public int? IdInsumo { get; set; }
        [Column("CANTIDADES")]
        public int? Cantidades { get; set; }
        [Column("ID_CLIENTE")]
        public int? IdCliente { get; set; }
        [Column("ID_SOLICITUD_RECOLECCION")]
        public int? IdSolicitudRecoleccion { get; set; }
        [Column("POSICION_INVENTARIO")]
        [StringLength(50)]
        public string PosicionInventario { get; set; }
        [Column("NO_TARIMA")]
        [StringLength(50)]
        public string NoTarima { get; set; }
        [Column("ID_RESPONSABLE")]
        public int? IdResponsable { get; set; }
        [Column("IS_NULL_CLIENTE")]
        public int? IsNullCliente { get; set; }
        [Column("IS_PROCESADA")]
        public int? IsProcesada { get; set; }
        [Column("ID_USUARIO_ALTA")]
        public int? IdUsuarioAlta { get; set; }
        [Column("FEC_ALTA", TypeName = "datetime")]
        public DateTime? FecAlta { get; set; }
        [Column("STATUS")]
        [StringLength(50)]
        public string Status { get; set; }
    }
}
