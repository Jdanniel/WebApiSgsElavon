using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class CStatusAr
{
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

    public virtual ICollection<BdCambioStatusAr> BdCambioStatusArIdStatusArFinNavigations { get; set; } = new List<BdCambioStatusAr>();

    public virtual ICollection<BdCambioStatusAr> BdCambioStatusArIdStatusArIniNavigations { get; set; } = new List<BdCambioStatusAr>();

    public virtual ICollection<BdProductoStatusAr> BdProductoStatusArs { get; set; } = new List<BdProductoStatusAr>();

    public virtual ICollection<CStatusArEq> CStatusArEqs { get; set; } = new List<CStatusArEq>();

    public virtual ICollection<CWincorEquivalenciasSg> CWincorEquivalenciasSgs { get; set; } = new List<CWincorEquivalenciasSg>();

    public virtual CTipoDowntimeTrigger IdTipoDowntimeTriggerNavigation { get; set; }
}
