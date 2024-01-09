using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class Vehiculo
{
    public int Id { get; set; }

    public string Curp { get; set; }

    public string Nombre { get; set; }

    public string Tipo { get; set; }

    public string Modelo { get; set; }

    public int? YearVehiculo { get; set; }

    public double? Mantenimiento { get; set; }

    public double? Renta { get; set; }

    public int? Year { get; set; }

    public int? Month { get; set; }
}
