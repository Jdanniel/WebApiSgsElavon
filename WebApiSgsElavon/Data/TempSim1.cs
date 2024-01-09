using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class TempSim1
{
    public int IdCliente { get; set; }

    public int IdAr { get; set; }

    public string NoAr { get; set; }

    public string AfiliacionDeRetiro { get; set; }

    public int TipoServicio { get; set; }

    public string NoSim { get; set; }

    public DateTime? FechaDeMovimiento { get; set; }

    public string CategoriaDeRecepcion { get; set; }

    public string Status { get; set; }

    public string SerieOAr { get; set; }

    public string Ubicacion { get; set; }

    public string Localidad { get; set; }

    public string AfiliacionDeInstalacion { get; set; }

    public string Avance { get; set; }

    public string NoSerieFalla { get; set; }

    public int IsExito { get; set; }
}
