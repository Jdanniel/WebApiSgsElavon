using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("C_RESPONSABLES")]
    public partial class CResponsables
    {
        [Column("ID_RESPONSABLES")]
        public int IdResponsables { get; set; }
        [Column("DESC_RESPONSABLE")]
        [StringLength(250)]
        public string DescResponsable { get; set; }
        [Column("ID_USUARIO_ALTA")]
        public int? IdUsuarioAlta { get; set; }
        [Column("FEC_ALTA", TypeName = "smalldatetime")]
        public DateTime? FecAlta { get; set; }
        [Column("STATUS")]
        [StringLength(50)]
        public string Status { get; set; }
        [Column("IS_ALMACEN")]
        public int? IsAlmacen { get; set; }
    }
}
