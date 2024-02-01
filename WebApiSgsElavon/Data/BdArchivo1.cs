using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.Data;

public partial class BdArchivo1
{
    public int IdCarga { get; set; }

    public int? IdCliente { get; set; }

    public string Ar { get; set; }

    public string Concepto { get; set; }

    public string DescCorta { get; set; }

    public string Síntoma { get; set; }

    public string Bitácora { get; set; }

    public string Afiliación { get; set; }

    public string Teléfono { get; set; }

    public string Negocio { get; set; }

    public string Dirección { get; set; }

    public string Colonia { get; set; }

    public string Población { get; set; }

    public string Estado { get; set; }

    public string Cp { get; set; }

    public string NotasRemedy { get; set; }

    public string IdEquipo { get; set; }

    public string DescEquipo { get; set; }

    public string IdSegmento { get; set; }

    public string Serie { get; set; }

    public string Inventario { get; set; }

    public string FechaInicio { get; set; }

    public string FechaConvenio { get; set; }

    public string FechaAtencion { get; set; }

    public string IdtipoServicio { get; set; }

    public string IdtipoFalla { get; set; }

    public string Idproyecto { get; set; }

    public string IdmodeloReq { get; set; }

    public string SeguimientoPorDispatch { get; set; }

    public string IsProgramado { get; set; }

    public string NoDiasLiberacion { get; set; }

    public int? Idconectividad { get; set; }

    public int? Idaplicativo { get; set; }

    public virtual BdCarga IdCargaNavigation { get; set; }

    public virtual CCliente IdClienteNavigation { get; set; }
}
