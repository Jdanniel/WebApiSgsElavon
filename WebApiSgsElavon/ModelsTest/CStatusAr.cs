using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.ModelsTest
{
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

        public int IdStatusAr { get; set; }
        public string DescStatusAr { get; set; }
        public int? Orden { get; set; }
        public int? IdTipoDowntimeTrigger { get; set; }
        public int? IsMovInvAllowed { get; set; }
        public int? IsSearchModule { get; set; }
        public int? IsSearchModuleChecked { get; set; }
        public int? IsControlModule { get; set; }
        public int? IsAbiertaModule { get; set; }
        public int? IsAbierta { get; set; }
        public int? IsCerrada { get; set; }
        public int? IsSolicitudAlmacen { get; set; }
        public int? IsSolicitudViaticos { get; set; }
        public int? IsSolicitudAgendado { get; set; }
        public int? IsVisitaAgendado { get; set; }
        public int? IsSoporteTecnico { get; set; }
        public int? IsAbiertaFreeze { get; set; }
        public int? IsTableroAniejos { get; set; }
        public int? IsBbNuevas { get; set; }
        public int? IsBbAbiertas { get; set; }
        public int? IsBbCerradas { get; set; }
        public int? IsBbPendientes { get; set; }
        public string Status { get; set; }
        public int? IsAsignacionTemporal { get; set; }
        public int? IsCargaTrabajoTecnico { get; set; }
        public int? IsPendiente { get; set; }
        public int? IsReasignacionTecnicoHorario { get; set; }
        public int? IsCierreMasivo { get; set; }
        public string RequestStatus { get; set; }
        public int? IsDesviacionTemporal { get; set; }
        public int? IsDesviacionNeeded { get; set; }
        public int? IsFecGarantiaChange { get; set; }
        public int? IsDesviacion { get; set; }
        public int? IsDesviacionDefault { get; set; }

        public virtual CTipoDowntimeTrigger IdTipoDowntimeTriggerNavigation { get; set; }
        public virtual ICollection<BdCambioStatusAr> BdCambioStatusArIdStatusArFinNavigation { get; set; }
        public virtual ICollection<BdCambioStatusAr> BdCambioStatusArIdStatusArIniNavigation { get; set; }
        public virtual ICollection<BdProductoStatusAr> BdProductoStatusAr { get; set; }
        public virtual ICollection<CStatusArEq> CStatusArEq { get; set; }
        public virtual ICollection<CWincorEquivalenciasSgs> CWincorEquivalenciasSgs { get; set; }
    }
}
