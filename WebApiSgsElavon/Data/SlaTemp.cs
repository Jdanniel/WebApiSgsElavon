using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class SlaTemp
{
    public int? IdRegion { get; set; }

    public int IdAr { get; set; }

    public string NoAr { get; set; }

    public DateTime FecInicio { get; set; }

    public DateTime? FecAtencion { get; set; }

    public DateTime? FecGarantia { get; set; }

    public DateTime? FecCierre { get; set; }

    public DateTime? FecStatus { get; set; }

    public DateTime? FecStatusZh { get; set; }

    public int IdCliente { get; set; }

    public int? IdStatusAr { get; set; }

    public int? IdZona { get; set; }

    public int? IdTecnico { get; set; }

    public string DescNegocio { get; set; }

    public int? IdServicio { get; set; }

    public int? IdSegmento { get; set; }

    public string NoAfiliacion { get; set; }

    public string DescEquipo { get; set; }

    public string Sintoma { get; set; }

    public int? Dia { get; set; }

    public string Califica { get; set; }

    public int Fuera { get; set; }

    public int Dentro { get; set; }

    public int Sla { get; set; }
}
