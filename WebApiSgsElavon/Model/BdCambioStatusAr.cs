using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_CAMBIO_STATUS_AR")]
    public partial class BdCambioStatusAr
    {
        [Key]
        [Column("ID_CAMBIO_STATUS_AR")]
        public int IdCambioStatusAr { get; set; }
        [Column("ID_CLIENTE")]
        public int? IdCliente { get; set; }
        [Column("ID_STATUS_AR_INI")]
        public int? IdStatusArIni { get; set; }
        [Column("ID_STATUS_AR_FIN")]
        public int? IdStatusArFin { get; set; }
        [Column("STATUS")]
        [StringLength(10)]
        public string Status { get; set; }
        [Column("ID_USUARIO_ALTA")]
        public int? IdUsuarioAlta { get; set; }
        [Column("FEC_ALTA", TypeName = "smalldatetime")]
        public DateTime? FecAlta { get; set; }

        [ForeignKey("IdStatusArFin")]
        [InverseProperty("BdCambioStatusArIdStatusArFinNavigation")]
        public virtual CStatusAr IdStatusArFinNavigation { get; set; }
        [ForeignKey("IdStatusArIni")]
        [InverseProperty("BdCambioStatusArIdStatusArIniNavigation")]
        public virtual CStatusAr IdStatusArIniNavigation { get; set; }
    }
}
