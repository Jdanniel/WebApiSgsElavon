using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_BITACORA_USUARIOS_ACTIVOS")]
    public partial class BdBitacoraUsuariosActivos
    {
        [Key]
        [Column("ID_BITACORA_USUARIOS_ACTIVOS")]
        public int IdBitacoraUsuariosActivos { get; set; }
        [Column("USUARIOS_ACTIVOS_WEB")]
        public int? UsuariosActivosWeb { get; set; }
        [Column("USUARIOS_ACTIVOS_PDA")]
        public int? UsuariosActivosPda { get; set; }
        [Column("TOTAL_USUARIOS_ACTIVOS")]
        public int? TotalUsuariosActivos { get; set; }
        [Column("FEC_ALTA", TypeName = "smalldatetime")]
        public DateTime? FecAlta { get; set; }
    }
}
