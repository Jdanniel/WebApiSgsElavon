using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class BdBitacoraServicio
{
    public int IdBitacoraServicios { get; set; }

    public int? IdServicio { get; set; }

    public string DescServicioAnterior { get; set; }

    public string DescServicioActual { get; set; }

    public string CodigoAnterior { get; set; }

    public string CodigoActual { get; set; }

    public string MinPromedioAnterior { get; set; }

    public string MinPromedioActual { get; set; }

    public string IsProyectoAnterior { get; set; }

    public string IsProyectoActual { get; set; }

    public string NoDiasAnterior { get; set; }

    public string NoDiasActual { get; set; }

    public string IsCallCenterAnterior { get; set; }

    public string IsCallCenterActual { get; set; }

    public string StatusAnterior { get; set; }

    public string StatusActual { get; set; }

    public DateTime? FecAlta { get; set; }

    public int? IdUsuariosAlta { get; set; }
}
