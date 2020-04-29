using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_AUDITORIAS")]
    public partial class BdAuditorias
    {
        public BdAuditorias()
        {
            BdAuditoriaReporte = new HashSet<BdAuditoriaReporte>();
        }

        [Key]
        [Column("ID_AUDITORIA")]
        public int IdAuditoria { get; set; }
        [Column("DESC_AUDITORIA")]
        [StringLength(255)]
        public string DescAuditoria { get; set; }
        [Column("ID_TIPO_AUDITORIA")]
        public int? IdTipoAuditoria { get; set; }
        [Column("FECHA_INICIO", TypeName = "datetime")]
        public DateTime? FechaInicio { get; set; }
        [Column("FECHA_FIN", TypeName = "datetime")]
        public DateTime? FechaFin { get; set; }
        [Column("ID_USUARIO_ALTA")]
        public int? IdUsuarioAlta { get; set; }
        [Column("FECHA_ALTA", TypeName = "datetime")]
        public DateTime? FechaAlta { get; set; }
        [Column("STATUS")]
        [StringLength(50)]
        public string Status { get; set; }
        [Column("ID_REGION")]
        public int? IdRegion { get; set; }

        [ForeignKey("IdTipoAuditoria")]
        [InverseProperty("BdAuditorias")]
        public virtual CTipoAuditoria IdTipoAuditoriaNavigation { get; set; }
        [ForeignKey("IdUsuarioAlta")]
        [InverseProperty("BdAuditorias")]
        public virtual CUsuarios IdUsuarioAltaNavigation { get; set; }
        [InverseProperty("IdAuditoriaNavigation")]
        public virtual ICollection<BdAuditoriaReporte> BdAuditoriaReporte { get; set; }
    }
}
