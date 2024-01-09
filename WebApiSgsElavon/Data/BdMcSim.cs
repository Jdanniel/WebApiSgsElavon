using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class BdMcSim
{
    public int IdSim { get; set; }

    public int IdCliente { get; set; }

    public int? IdSolicitudRecoleccion { get; set; }

    public string NoSim { get; set; }

    public int? IdUnidad { get; set; }

    public int? IdCarrier { get; set; }

    public int? IdUsuarioAlta { get; set; }

    public DateTime? FecAlta { get; set; }

    public int? IdUsuarioStatus { get; set; }

    public DateTime? FecStatus { get; set; }

    public string Status { get; set; }

    public int? IdStatusSim { get; set; }

    public int? IsDisponible { get; set; }

    public int? IsNuevo { get; set; }

    public int? IsDaniada { get; set; }

    public int? IdResponsable { get; set; }

    public int? IdTipoResponsable { get; set; }

    public int? IsRetiro { get; set; }

    public int? IdItemsSolicitudAlmacen { get; set; }

    public decimal? Costo { get; set; }

    public int? IdMoneda { get; set; }

    public virtual ICollection<BdEnvioSim> BdEnvioSims { get; set; } = new List<BdEnvioSim>();

    public virtual BdUnidade IdUnidadNavigation { get; set; }
}
