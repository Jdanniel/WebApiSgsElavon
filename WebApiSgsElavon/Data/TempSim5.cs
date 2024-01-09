using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class TempSim5
{
    public string AfiliacionDeRetiro { get; set; }

    public string NoSim { get; set; }

    public string NoAr { get; set; }

    public string NCaracteres { get; set; }

    public string FechaMovimiento { get; set; }

    public string CategoriaDeRecepcion { get; set; }

    public string Compania { get; set; }

    public string Status { get; set; }

    public string NoSerie { get; set; }

    public string Ubicacion { get; set; }

    public string Localidad { get; set; }

    public string AfiliacionDeInstalacion { get; set; }

    public int? IsRepetido { get; set; }

    public string Avance { get; set; }

    public DateTime? FechaDeMovimiento { get; set; }
}
