using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_SERVICIO_CAUSA")]
    public partial class BdServicioCausa
    {
        [Key]
        [Column("ID_SERVICIO_CAUSA")]
        public int IdServicioCausa { get; set; }
        [Column("ID_SERVICIO")]
        public int IdServicio { get; set; }
        [Column("ID_CAUSA")]
        public int IdCausa { get; set; }
        [Column("ID_USUARIO_ALTA")]
        public int? IdUsuarioAlta { get; set; }
        [Column("FEC_ALTA", TypeName = "smalldatetime")]
        public DateTime? FecAlta { get; set; }

        [ForeignKey("IdCausa")]
        [InverseProperty("BdServicioCausa")]
        public virtual CCausas IdCausaNavigation { get; set; }
        [ForeignKey("IdServicio")]
        [InverseProperty("BdServicioCausa")]
        public virtual CServicios IdServicioNavigation { get; set; }
    }
}
