using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_BITACORA_AGENDADOS")]
    public partial class BdBitacoraAgendados
    {
        [Column("ID_BITACORA_AGENDADO")]
        public int IdBitacoraAgendado { get; set; }
        [Column("ID_AR")]
        public int IdAr { get; set; }
        [Column("FEC_ATENCION_INI", TypeName = "smalldatetime")]
        public DateTime FecAtencionIni { get; set; }
        [Column("FEC_ATENCION_FIN", TypeName = "smalldatetime")]
        public DateTime FecAtencionFin { get; set; }
        [Column("ID_RESPONSABLE_AGENDADO")]
        public int IdResponsableAgendado { get; set; }
        [Required]
        [Column("AUTORIZADOR")]
        [StringLength(250)]
        public string Autorizador { get; set; }
        [Column("COMENTARIO")]
        [StringLength(500)]
        public string Comentario { get; set; }
        [Column("IS_VISITA_AGENDADO")]
        public int? IsVisitaAgendado { get; set; }
        [Column("FOLIO_TIR")]
        [StringLength(15)]
        public string FolioTir { get; set; }
        [Column("ID_USUARIO_ALTA")]
        public int? IdUsuarioAlta { get; set; }
        [Column("FEC_ALTA", TypeName = "smalldatetime")]
        public DateTime? FecAlta { get; set; }
        [Column("ID_COMENTARIO_AGENDADO")]
        public int? IdComentarioAgendado { get; set; }

        [ForeignKey("IdResponsableAgendado")]
        [InverseProperty("BdBitacoraAgendados")]
        public virtual CResponsablesAgendados IdResponsableAgendadoNavigation { get; set; }
    }
}
