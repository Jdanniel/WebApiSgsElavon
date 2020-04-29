using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_AR_ACCESORIOS")]
    public partial class BdArAccesorios
    {
        [Column("ID_AR_ACCESORIO")]
        public int IdArAccesorio { get; set; }
        [Column("ID_AR")]
        public int? IdAr { get; set; }
        [Column("BATERIA")]
        [StringLength(10)]
        public string Bateria { get; set; }
        [Column("ELIMINADOR")]
        [StringLength(10)]
        public string Eliminador { get; set; }
        [Column("BASE")]
        [StringLength(10)]
        public string Base { get; set; }
        [Column("TAPA")]
        [StringLength(10)]
        public string Tapa { get; set; }
        [Column("CABLE_AC")]
        [StringLength(10)]
        public string CableAc { get; set; }
        [Column("MOVIMIENTO")]
        [StringLength(20)]
        public string Movimiento { get; set; }
    }
}
