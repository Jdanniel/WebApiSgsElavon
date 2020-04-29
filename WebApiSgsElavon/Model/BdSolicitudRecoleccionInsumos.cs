using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_SOLICITUD_RECOLECCION_INSUMOS")]
    public partial class BdSolicitudRecoleccionInsumos
    {
        [Key]
        [Column("ID_SOLICITUD_RECOLECCION_INSUMOS")]
        public int IdSolicitudRecoleccionInsumos { get; set; }
        [Column("ID_SOLICITUD_RECOLECCION")]
        public int? IdSolicitudRecoleccion { get; set; }
        [Column("ID_INSUMO")]
        public int? IdInsumo { get; set; }
        [Column("CANTIDADES")]
        public int? Cantidades { get; set; }
        [Column("FEC_ALTA", TypeName = "datetime")]
        public DateTime? FecAlta { get; set; }
        [Column("ID_USUARIO_ALTA")]
        public int? IdUsuarioAlta { get; set; }

        [ForeignKey("IdSolicitudRecoleccion")]
        [InverseProperty("BdSolicitudRecoleccionInsumos")]
        public virtual BdSolicitudRecoleccion IdSolicitudRecoleccionNavigation { get; set; }
    }
}
