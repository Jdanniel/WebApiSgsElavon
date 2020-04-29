using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("C_STATUS_AR")]
    public partial class CStatusAr
    {
        public CStatusAr()
        {
            BdCambioStatusArIdStatusArFinNavigation = new HashSet<BdCambioStatusAr>();
            BdCambioStatusArIdStatusArIniNavigation = new HashSet<BdCambioStatusAr>();
            BdProductoStatusAr = new HashSet<BdProductoStatusAr>();
            CStatusArEq = new HashSet<CStatusArEq>();
            CWincorEquivalenciasSgs = new HashSet<CWincorEquivalenciasSgs>();
        }

        [Key]
        [Column("ID_STATUS_AR")]
        public int IdStatusAr { get; set; }
        [Column("DESC_STATUS_AR")]
        [StringLength(50)]
        public string DescStatusAr { get; set; }
        [Column("ORDEN")]
        public int? Orden { get; set; }
        [Column("ID_TIPO_DOWNTIME_TRIGGER")]
        public int? IdTipoDowntimeTrigger { get; set; }
        [Column("IS_MOV_INV_ALLOWED")]
        public int? IsMovInvAllowed { get; set; }
        [Column("IS_SEARCH_MODULE")]
        public int? IsSearchModule { get; set; }
        [Column("IS_SEARCH_MODULE_CHECKED")]
        public int? IsSearchModuleChecked { get; set; }
        [Column("IS_CONTROL_MODULE")]
        public int? IsControlModule { get; set; }
        [Column("IS_ABIERTA_MODULE")]
        public int? IsAbiertaModule { get; set; }
        [Column("IS_ABIERTA")]
        public int? IsAbierta { get; set; }
        [Column("IS_CERRADA")]
        public int? IsCerrada { get; set; }
        [Column("IS_SOLICITUD_ALMACEN")]
        public int? IsSolicitudAlmacen { get; set; }
        [Column("IS_SOLICITUD_VIATICOS")]
        public int? IsSolicitudViaticos { get; set; }
        [Column("IS_SOLICITUD_AGENDADO")]
        public int? IsSolicitudAgendado { get; set; }
        [Column("IS_VISITA_AGENDADO")]
        public int? IsVisitaAgendado { get; set; }
        [Column("IS_SOPORTE_TECNICO")]
        public int? IsSoporteTecnico { get; set; }
        [Column("IS_ABIERTA_FREEZE")]
        public int? IsAbiertaFreeze { get; set; }
        [Column("IS_TABLERO_ANIEJOS")]
        public int? IsTableroAniejos { get; set; }
        [Column("IS_BB_NUEVAS")]
        public int? IsBbNuevas { get; set; }
        [Column("IS_BB_ABIERTAS")]
        public int? IsBbAbiertas { get; set; }
        [Column("IS_BB_CERRADAS")]
        public int? IsBbCerradas { get; set; }
        [Column("IS_BB_PENDIENTES")]
        public int? IsBbPendientes { get; set; }
        [Column("STATUS")]
        [StringLength(10)]
        public string Status { get; set; }
        [Column("IS_ASIGNACION_TEMPORAL")]
        public int? IsAsignacionTemporal { get; set; }
        [Column("IS_CARGA_TRABAJO_TECNICO")]
        public int? IsCargaTrabajoTecnico { get; set; }
        [Column("IS_PENDIENTE")]
        public int? IsPendiente { get; set; }
        [Column("IS_REASIGNACION_TECNICO_HORARIO")]
        public int? IsReasignacionTecnicoHorario { get; set; }
        [Column("IS_CIERRE_MASIVO")]
        public int? IsCierreMasivo { get; set; }
        [Column("request_status")]
        [StringLength(250)]
        public string RequestStatus { get; set; }
        [Column("IS_DESVIACION_TEMPORAL")]
        public int? IsDesviacionTemporal { get; set; }
        [Column("IS_DESVIACION_NEEDED")]
        public int? IsDesviacionNeeded { get; set; }
        [Column("IS_FEC_GARANTIA_CHANGE")]
        public int? IsFecGarantiaChange { get; set; }
        [Column("IS_DESVIACION")]
        public int? IsDesviacion { get; set; }
        [Column("IS_DESVIACION_DEFAULT")]
        public int? IsDesviacionDefault { get; set; }

        [ForeignKey("IdTipoDowntimeTrigger")]
        [InverseProperty("CStatusAr")]
        public virtual CTipoDowntimeTrigger IdTipoDowntimeTriggerNavigation { get; set; }
        [InverseProperty("IdStatusArFinNavigation")]
        public virtual ICollection<BdCambioStatusAr> BdCambioStatusArIdStatusArFinNavigation { get; set; }
        [InverseProperty("IdStatusArIniNavigation")]
        public virtual ICollection<BdCambioStatusAr> BdCambioStatusArIdStatusArIniNavigation { get; set; }
        [InverseProperty("IdStatusArNavigation")]
        public virtual ICollection<BdProductoStatusAr> BdProductoStatusAr { get; set; }
        [InverseProperty("IdStatusArNavigation")]
        public virtual ICollection<CStatusArEq> CStatusArEq { get; set; }
        [InverseProperty("IdStatusArNavigation")]
        public virtual ICollection<CWincorEquivalenciasSgs> CWincorEquivalenciasSgs { get; set; }
    }
}
