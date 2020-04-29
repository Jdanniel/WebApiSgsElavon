using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_CLAVE_ESTADO")]
    public partial class BdClaveEstado
    {
        [Column("ID_CLAVE_ESTADO")]
        public int IdClaveEstado { get; set; }
        [Column("ID_ESTADO")]
        public int? IdEstado { get; set; }
        [Column("CLAVE")]
        [StringLength(50)]
        public string Clave { get; set; }
        [Column("FEC_ALTA", TypeName = "smalldatetime")]
        public DateTime? FecAlta { get; set; }
        [Column("ID_USUARIO_ALTA")]
        public int? IdUsuarioAlta { get; set; }

        [ForeignKey("IdEstado")]
        [InverseProperty("BdClaveEstado")]
        public virtual SepomexEstados IdEstadoNavigation { get; set; }
    }
}
