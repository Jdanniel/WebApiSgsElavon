using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class GuiasCosto
{
    public int Id { get; set; }

    public string NoCuenta { get; set; }

    public string NoGuia { get; set; }

    public string CiudadOrigen { get; set; }

    public string CiudadDestino { get; set; }

    public int? Piezas { get; set; }

    public double? Peso { get; set; }

    public DateOnly? FechaColeccion { get; set; }

    public DateOnly? FechaEntrega { get; set; }

    public string UltimoCheckpoint { get; set; }

    public string DetallesEntrega { get; set; }

    public string Producto { get; set; }

    public int? Year { get; set; }

    public int? Month { get; set; }

    public double? Costo { get; set; }
}
