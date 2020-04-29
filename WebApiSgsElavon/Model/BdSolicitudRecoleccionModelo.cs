using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_SOLICITUD_RECOLECCION_MODELO")]
    public partial class BdSolicitudRecoleccionModelo
    {
        [Key]
        [Column("ID_SOLICITUD_RECOLECCION_MODELO")]
        public int IdSolicitudRecoleccionModelo { get; set; }
        [Column("ID_SOLICITUD_RECOLECCION")]
        public int? IdSolicitudRecoleccion { get; set; }
        [Column("ID_MODELO")]
        public int? IdModelo { get; set; }
        [Column("NO_UNIDADES")]
        public int? NoUnidades { get; set; }
        [Column("ID_USUARIO_ALTA")]
        public int? IdUsuarioAlta { get; set; }
        [Column("FEC_ALTA", TypeName = "smalldatetime")]
        public DateTime? FecAlta { get; set; }

        [ForeignKey("IdSolicitudRecoleccion")]
        [InverseProperty("BdSolicitudRecoleccionModelo")]
        public virtual BdSolicitudRecoleccion IdSolicitudRecoleccionNavigation { get; set; }
    }
}
