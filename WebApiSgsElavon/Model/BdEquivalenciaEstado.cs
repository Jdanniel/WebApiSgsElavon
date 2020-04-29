using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_EQUIVALENCIA_ESTADO")]
    public partial class BdEquivalenciaEstado
    {
        [Column("ID_EQUIVALENCIA_ESTADO")]
        public int IdEquivalenciaEstado { get; set; }
        [Column("DESC_ESTADO")]
        [StringLength(255)]
        public string DescEstado { get; set; }
        [Column("DESC_ESTADO_EQUIVALENCIA")]
        [StringLength(255)]
        public string DescEstadoEquivalencia { get; set; }
        [Column("FEC_ALTA", TypeName = "datetime")]
        public DateTime? FecAlta { get; set; }
        [Column("ID_USUARIO_ALTA")]
        public int? IdUsuarioAlta { get; set; }
    }
}
