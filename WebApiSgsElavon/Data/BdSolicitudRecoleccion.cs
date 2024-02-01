using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.Data;

public partial class BdSolicitudRecoleccion
{
    public int IdSolicitudRecoleccion { get; set; }

    public int? IdCliente { get; set; }

    public int? IdAlmacenDestino { get; set; }

    public string Distribuidor { get; set; }

    public int? NoUnidades { get; set; }

    public int? IdServicioMensajeria { get; set; }

    public string CalleNum { get; set; }

    public string Colonia { get; set; }

    public string Delegacion { get; set; }

    public string Ciudad { get; set; }

    public string Estado { get; set; }

    public string Cp { get; set; }

    public DateTime? FecRecoleccion { get; set; }

    public DateTime? HoraRecoleccion { get; set; }

    public int? IdUnidadMensajeria { get; set; }

    public int? IdChofer { get; set; }

    public int? IdStatusSolicitudRecoleccion { get; set; }

    public int? IdAttachSolicitud { get; set; }

    public int? IdUsuarioAlta { get; set; }

    public DateTime? FecAlta { get; set; }

    public int? IdTipoSolicitud { get; set; }

    public int? Cantidades { get; set; }

    public virtual ICollection<BdBitacoraSolicitudRecoleccion> BdBitacoraSolicitudRecoleccions { get; set; } = new List<BdBitacoraSolicitudRecoleccion>();

    public virtual ICollection<BdReingresoSim> BdReingresoSimIdSolicitudRecoleccionAnteriorNavigations { get; set; } = new List<BdReingresoSim>();

    public virtual ICollection<BdReingresoSim> BdReingresoSimIdSolicitudRecoleccionReingresoNavigations { get; set; } = new List<BdReingresoSim>();

    public virtual ICollection<BdReingresoUnidad> BdReingresoUnidadIdSolicitudRecoleccionAnteriorNavigations { get; set; } = new List<BdReingresoUnidad>();

    public virtual ICollection<BdReingresoUnidad> BdReingresoUnidadIdSolicitudRecoleccionReingresoNavigations { get; set; } = new List<BdReingresoUnidad>();

    public virtual ICollection<BdSolicitudRecoleccionInsumo> BdSolicitudRecoleccionInsumos { get; set; } = new List<BdSolicitudRecoleccionInsumo>();

    public virtual ICollection<BdSolicitudRecoleccionModelo> BdSolicitudRecoleccionModelos { get; set; } = new List<BdSolicitudRecoleccionModelo>();

    public virtual CStatusSolicitudRecoleccion IdStatusSolicitudRecoleccionNavigation { get; set; }
}
