using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class Nomina
{
    public int Id { get; set; }

    public string Curp { get; set; }

    public int NumEmpleado { get; set; }

    public string Nombre { get; set; }

    public double? Total { get; set; }

    public DateOnly FecAntiguedad { get; set; }

    public string FecBaja { get; set; }

    public string Status { get; set; }

    public int Year { get; set; }

    public int Month { get; set; }

    public double? Fijo { get; set; }

    public double? Transporte { get; set; }

    public double? Variable { get; set; }
}
