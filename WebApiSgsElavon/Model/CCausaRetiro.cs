using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("C_CAUSA_RETIRO")]
    public partial class CCausaRetiro
    {
        [Column("ID_CAUSA_RETIRO")]
        public int IdCausaRetiro { get; set; }
        [Column("ID_USUARIO_ALTA")]
        public int? IdUsuarioAlta { get; set; }
        [Column("ID_CLIENTE")]
        public int? IdCliente { get; set; }
        [Column("CAUSA_RETIRO")]
        [StringLength(255)]
        public string CausaRetiro { get; set; }
        [Column("FECHA_ALTA", TypeName = "datetime")]
        public DateTime? FechaAlta { get; set; }
        [Column("STATUS")]
        [StringLength(255)]
        public string Status { get; set; }
    }
}
