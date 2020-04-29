using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_REPORTE_MOV_INVENTARIO")]
    public partial class BdReporteMovInventario
    {
        [Key]
        [Column("ID_BD_REPORTE_MOV_INVENTARIO")]
        public int IdBdReporteMovInventario { get; set; }
        [Column("ID_REPORTE_MOV_INVENTARIO")]
        public int IdReporteMovInventario { get; set; }
        [Column("ID_CLIENTE")]
        public int? IdCliente { get; set; }
        [Column("ID_ALMACEN")]
        public int? IdAlmacen { get; set; }
        [Column("ID_MODELO")]
        public int? IdModelo { get; set; }
        [Column("DIA_SEMANA")]
        [StringLength(10)]
        public string DiaSemana { get; set; }
        [Column("U_INV_LAB")]
        public int? UInvLab { get; set; }
        [Column("U_DISP_INICIO_DIA")]
        public int? UDispInicioDia { get; set; }
        [Column("U_ENTRADAS_DIA")]
        public int? UEntradasDia { get; set; }
        [Column("U_ENTRADAS_LAB")]
        public int? UEntradasLab { get; set; }
        [Column("U_SAL_INST")]
        public int? USalInst { get; set; }
        [Column("U_SAL_MANTO")]
        public int? USalManto { get; set; }
        [Column("U_SAL_LAB")]
        public int? USalLab { get; set; }

        [ForeignKey("IdReporteMovInventario")]
        [InverseProperty("BdReporteMovInventario")]
        public virtual CReporteMovInventario IdReporteMovInventarioNavigation { get; set; }
    }
}
