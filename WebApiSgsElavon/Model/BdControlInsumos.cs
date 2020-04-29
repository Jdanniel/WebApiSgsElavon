using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_CONTROL_INSUMOS")]
    public partial class BdControlInsumos
    {
        [Column("ID_BD_CONTROL_INSUMOS")]
        public int IdBdControlInsumos { get; set; }
        [Column("ID_CLIENTE")]
        public int? IdCliente { get; set; }
        [Column("ID_INSUMO")]
        public int? IdInsumo { get; set; }
        [Column("ENTRADA")]
        public int? Entrada { get; set; }
        [Column("SALIDA")]
        public int? Salida { get; set; }
        [Column("TOTAL")]
        public int? Total { get; set; }
        [Column("NO_TARIMA")]
        [StringLength(100)]
        public string NoTarima { get; set; }
        [Column("POSICION_INVENTARIO")]
        [StringLength(100)]
        public string PosicionInventario { get; set; }
        [Column("ID_TIPO_RESPONSABLE")]
        public int? IdTipoResponsable { get; set; }
        [Column("ID_RESPONSABLE")]
        public int? IdResponsable { get; set; }
        [Column("ID_STATUS_INSUMO")]
        public int? IdStatusInsumo { get; set; }
    }
}
