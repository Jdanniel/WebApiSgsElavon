using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_DIRECCIONES_RELACIONES")]
    public partial class BdDireccionesRelaciones
    {
        [Key]
        [Column("ID_DIRECCION_RELACION")]
        public int IdDireccionRelacion { get; set; }
        [Column("ID_DIRECCION")]
        public int IdDireccion { get; set; }
        [Column("ID_TIPO_RESPONSABLE")]
        public int IdTipoResponsable { get; set; }
        [Column("ID_RESPONSABLE")]
        public int IdResponsable { get; set; }
        [Column("FEC_ALTA", TypeName = "smalldatetime")]
        public DateTime FecAlta { get; set; }
        [Column("ID_USUARIO_ALTA")]
        public int IdUsuarioAlta { get; set; }
        [Column("IS_DEFAULT")]
        public int? IsDefault { get; set; }
    }
}
