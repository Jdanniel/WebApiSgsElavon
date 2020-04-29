using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_SERVICIO_MOV_INV")]
    public partial class BdServicioMovInv
    {
        [Column("ID_SERVICIO_MOV_INV")]
        public int IdServicioMovInv { get; set; }
        [Column("ID_CLIENTE")]
        public int? IdCliente { get; set; }
        [Column("ID_SERVICIO")]
        public int IdServicio { get; set; }
        [Column("ID_MOV_INV")]
        public int IdMovInv { get; set; }
        [Column("IS_REQUIRED")]
        public int? IsRequired { get; set; }
        [Column("FEC_ALTA", TypeName = "smalldatetime")]
        public DateTime? FecAlta { get; set; }
        [Column("ID_USUARIO_ALTA")]
        public int? IdUsuarioAlta { get; set; }

        [ForeignKey("IdMovInv")]
        [InverseProperty("BdServicioMovInv")]
        public virtual CMovInv IdMovInvNavigation { get; set; }
    }
}
