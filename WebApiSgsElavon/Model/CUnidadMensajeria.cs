using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("C_UNIDAD_MENSAJERIA")]
    public partial class CUnidadMensajeria
    {
        public CUnidadMensajeria()
        {
            BdSolicitudRecoleccion = new HashSet<BdSolicitudRecoleccion>();
        }

        [Key]
        [Column("ID_UNIDAD_MENSAJERIA")]
        public int IdUnidadMensajeria { get; set; }
        [Column("ID_SERVICIO_MENSAJERIA")]
        public int IdServicioMensajeria { get; set; }
        [Column("DESC_UNIDAD_MENSAJERIA")]
        [StringLength(250)]
        public string DescUnidadMensajeria { get; set; }
        [Required]
        [Column("STATUS")]
        [StringLength(10)]
        public string Status { get; set; }
        [Column("ID_USUARIO_ALTA")]
        public int IdUsuarioAlta { get; set; }
        [Column("FEC_ALTA", TypeName = "smalldatetime")]
        public DateTime FecAlta { get; set; }

        [InverseProperty("IdUnidadMensajeriaNavigation")]
        public virtual ICollection<BdSolicitudRecoleccion> BdSolicitudRecoleccion { get; set; }
    }
}
