using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_SOLICITUDES_DEVOLUCION_MODELO")]
    public partial class BdSolicitudesDevolucionModelo
    {
        [Key]
        [Column("ID_SOLICITUD_DEVOLUCION_MODELO")]
        public int IdSolicitudDevolucionModelo { get; set; }
        [Column("ID_SOLICITUD_DEVOLUCION")]
        public int? IdSolicitudDevolucion { get; set; }
        [Column("ID_MODELO")]
        public int? IdModelo { get; set; }
        [Column("NO_UNIDADES")]
        public int? NoUnidades { get; set; }
        [Column("ID_USUARIO_ALTA")]
        public int? IdUsuarioAlta { get; set; }
        [Column("FEC_ALTA", TypeName = "smalldatetime")]
        public DateTime? FecAlta { get; set; }

        [ForeignKey("IdModelo")]
        [InverseProperty("BdSolicitudesDevolucionModelo")]
        public virtual CModelos IdModeloNavigation { get; set; }
        [ForeignKey("IdUsuarioAlta")]
        [InverseProperty("BdSolicitudesDevolucionModelo")]
        public virtual CUsuarios IdUsuarioAltaNavigation { get; set; }
    }
}
