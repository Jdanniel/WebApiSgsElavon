using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.Data;

public partial class CTipoResponsable
{
    public int IdTipoResponsable { get; set; }

    public string DescTipoResponsable { get; set; }

    public string Status { get; set; }

    public virtual ICollection<BdBitacoraInsumo> BdBitacoraInsumos { get; set; } = new List<BdBitacoraInsumo>();

    public virtual ICollection<BdBitacoraUnidad> BdBitacoraUnidads { get; set; } = new List<BdBitacoraUnidad>();

    public virtual ICollection<BdControlInsumosDetalle> BdControlInsumosDetalles { get; set; } = new List<BdControlInsumosDetalle>();

    public virtual ICollection<BdEnvio> BdEnvioIdTipoResponsableDestinoNavigations { get; set; } = new List<BdEnvio>();

    public virtual ICollection<BdEnvio> BdEnvioIdTipoResponsableOrigenNavigations { get; set; } = new List<BdEnvio>();

    public virtual ICollection<BdReingresoUnidad> BdReingresoUnidadIdTipoResponsableAnteriorNavigations { get; set; } = new List<BdReingresoUnidad>();

    public virtual ICollection<BdReingresoUnidad> BdReingresoUnidadIdTipoResponsableReingresoNavigations { get; set; } = new List<BdReingresoUnidad>();
    public virtual ICollection<BdSolicitudesAlmacen> BdSolicitudesAlmacens { get; set; } = new List<BdSolicitudesAlmacen>();
}
