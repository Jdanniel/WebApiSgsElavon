using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("SI_BD_LOG")]
    public partial class SiBdLog
    {
        [Key]
        [Column("ID_LOG")]
        public int IdLog { get; set; }
        [Column("ID_SERVICIO")]
        public int? IdServicio { get; set; }
        [Column("FEC_ALTA", TypeName = "datetime")]
        public DateTime? FecAlta { get; set; }
        [Column("RESPONSABLE")]
        [StringLength(60)]
        public string Responsable { get; set; }
        [Column("ESTADO_SERVICIO")]
        [StringLength(60)]
        public string EstadoServicio { get; set; }
        [Column("DESCRIPCION")]
        [StringLength(250)]
        public string Descripcion { get; set; }
    }
}
