using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_SERVICIO_SOLUCION")]
    public partial class BdServicioSolucion
    {
        [Key]
        [Column("ID_SERVICIO_SOLUCION")]
        public int IdServicioSolucion { get; set; }
        [Column("ID_SERVICIO")]
        public int IdServicio { get; set; }
        [Column("ID_SOLUCION")]
        public int IdSolucion { get; set; }
        [Column("ID_USUARIO_ALTA")]
        public int? IdUsuarioAlta { get; set; }
        [Column("FEC_ALTA", TypeName = "smalldatetime")]
        public DateTime? FecAlta { get; set; }

        [ForeignKey("IdServicio")]
        [InverseProperty("BdServicioSolucion")]
        public virtual CServicios IdServicioNavigation { get; set; }
        [ForeignKey("IdSolucion")]
        [InverseProperty("BdServicioSolucion")]
        public virtual CSoluciones IdSolucionNavigation { get; set; }
    }
}
