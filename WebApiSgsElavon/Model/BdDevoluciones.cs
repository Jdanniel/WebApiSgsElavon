using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_DEVOLUCIONES")]
    public partial class BdDevoluciones
    {
        [Key]
        [Column("ID_DEVOLUCION")]
        public int IdDevolucion { get; set; }
        [Column("ID_CLIENTE")]
        public int? IdCliente { get; set; }
        [Column("ID_UNIDAD")]
        public int? IdUnidad { get; set; }
        [Column("NO_SERIE")]
        [StringLength(50)]
        public string NoSerie { get; set; }
        [Column("ID_RAZON_DEVOLUCION")]
        public int? IdRazonDevolucion { get; set; }
        [Column("DESC_ENCARGADO_RECEPCION")]
        [StringLength(255)]
        public string DescEncargadoRecepcion { get; set; }
        [Column("DESC_LUGAR_RECEPCION")]
        [StringLength(255)]
        public string DescLugarRecepcion { get; set; }
        [Column("FEC_DEVOLUCION", TypeName = "smalldatetime")]
        public DateTime? FecDevolucion { get; set; }
        [Column("ID_USUARIO_ALTA")]
        public int? IdUsuarioAlta { get; set; }

        [ForeignKey("IdCliente")]
        [InverseProperty("BdDevoluciones")]
        public virtual CClientes IdClienteNavigation { get; set; }
        [ForeignKey("IdRazonDevolucion")]
        [InverseProperty("BdDevoluciones")]
        public virtual CRazonDevolucion IdRazonDevolucionNavigation { get; set; }
        [ForeignKey("IdUnidad")]
        [InverseProperty("BdDevoluciones")]
        public virtual BdUnidades IdUnidadNavigation { get; set; }
    }
}
