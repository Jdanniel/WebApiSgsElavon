using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("C_MC_VIATICOS_RAZONES_CANCELACION")]
    public partial class CMcViaticosRazonesCancelacion
    {
        [Column("ID_RAZON")]
        public int IdRazon { get; set; }
        [Required]
        [Column("COMENTARIO")]
        [StringLength(400)]
        public string Comentario { get; set; }
        [Required]
        [Column("STATUS")]
        [StringLength(19)]
        public string Status { get; set; }
        [Column("ID_USUARIO_ALTA")]
        public int? IdUsuarioAlta { get; set; }
        [Column("FEC_ALTA", TypeName = "datetime")]
        public DateTime? FecAlta { get; set; }
    }
}
