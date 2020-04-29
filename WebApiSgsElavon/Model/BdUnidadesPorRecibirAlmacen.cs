using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_UNIDADES_POR_RECIBIR_ALMACEN")]
    public partial class BdUnidadesPorRecibirAlmacen
    {
        [Key]
        [Column("ID_RECEPCION")]
        public int IdRecepcion { get; set; }
        [Required]
        [Column("NO_SERIE")]
        [StringLength(50)]
        public string NoSerie { get; set; }
        [Column("FEC_ALTA", TypeName = "smalldatetime")]
        public DateTime? FecAlta { get; set; }
        [Column("ID_JEFE_ALMACEN")]
        public int? IdJefeAlmacen { get; set; }
        [Column("IS_PROCESADA")]
        public int IsProcesada { get; set; }
        [Required]
        [Column("POSICION_INVENTARIO")]
        [StringLength(50)]
        public string PosicionInventario { get; set; }
    }
}
