using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("C_DIRECCIONES")]
    public partial class CDirecciones
    {
        [Key]
        [Column("ID_DIRECCIONES")]
        public int IdDirecciones { get; set; }
        [Column("DESC_DIRECCION")]
        [StringLength(250)]
        public string DescDireccion { get; set; }
        [Column("ID_DIRECCIONES_JEFE")]
        public int? IdDireccionesJefe { get; set; }
        [Column("ID_USUARIO_ALTA")]
        public int? IdUsuarioAlta { get; set; }
        [Column("STATUS")]
        [StringLength(250)]
        public string Status { get; set; }
        [Column("FEC_ALTA", TypeName = "smalldatetime")]
        public DateTime? FecAlta { get; set; }
    }
}
