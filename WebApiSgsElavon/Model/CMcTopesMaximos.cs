using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("C_MC_TOPES_MAXIMOS")]
    public partial class CMcTopesMaximos
    {
        [Key]
        [Column("ID_TOPE_MAXIMO")]
        public int IdTopeMaximo { get; set; }
        [Column("ID_VIATICO")]
        public int? IdViatico { get; set; }
        [Column("PRECIO_MAXIMO")]
        [StringLength(10)]
        public string PrecioMaximo { get; set; }
        [Column("ESTATUS")]
        [StringLength(10)]
        public string Estatus { get; set; }
    }
}
