using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("C_CHOFERES")]
    public partial class CChoferes
    {
        public CChoferes()
        {
            BdSolicitudRecoleccion = new HashSet<BdSolicitudRecoleccion>();
        }

        [Key]
        [Column("ID_CHOFER")]
        public int IdChofer { get; set; }
        [Column("ID_SERVICIO_MENSAJERIA")]
        public int IdServicioMensajeria { get; set; }
        [Required]
        [Column("NOMBRE")]
        [StringLength(50)]
        public string Nombre { get; set; }
        [Required]
        [Column("PATERNO")]
        [StringLength(50)]
        public string Paterno { get; set; }
        [Required]
        [Column("MATERNO")]
        [StringLength(50)]
        public string Materno { get; set; }
        [Required]
        [Column("STATUS")]
        [StringLength(10)]
        public string Status { get; set; }
        [Column("ID_USUARIO_ALTA")]
        public int IdUsuarioAlta { get; set; }
        [Column("FEC_ALTA", TypeName = "smalldatetime")]
        public DateTime FecAlta { get; set; }

        [InverseProperty("IdChoferNavigation")]
        public virtual ICollection<BdSolicitudRecoleccion> BdSolicitudRecoleccion { get; set; }
    }
}
