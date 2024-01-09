using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class DispersionNomina
{
    public int Id { get; set; }

    public string Curp { get; set; }

    public string Nombre { get; set; }

    public string Region { get; set; }

    public string Zona { get; set; }

    public string TipoPuesto { get; set; }

    public string DescPuesto { get; set; }

    public string TipoRecurso { get; set; }

    public string Proyecto { get; set; }

    public double Atm { get; set; }

    public double Modem { get; set; }

    public double Otros { get; set; }

    public double Seguridad { get; set; }

    public double Tnm { get; set; }

    public double Tpv { get; set; }

    public double TresM { get; set; }

    public int? Year { get; set; }

    public int? Month { get; set; }
}
