using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class TempDhl
{
    public double? Item { get; set; }

    public string Iata { get; set; }

    public string TypeOfFacility { get; set; }

    public string Nombre { get; set; }

    public double? CeCoActual { get; set; }

    public double? CuentaIbs { get; set; }

    public string Estado { get; set; }

    public string Ciudad { get; set; }

    public string DirecciónCompleta { get; set; }

    public string Calle { get; set; }

    public double? Exterior { get; set; }

    public double? Interior { get; set; }

    public string Colonia { get; set; }

    public double? CP { get; set; }

    public string ReferenciasParaLlegarALaTienda { get; set; }

    public string EntreCalles { get; set; }

    public string Teléfonos { get; set; }

    public string Fax { get; set; }

    public string HorariosLunesAViernes { get; set; }

    public string HorarioComida { get; set; }

    public string HorarioSábados { get; set; }

    public string HorarioDíasFestivos { get; set; }

    public DateTime? Domestico { get; set; }

    public DateTime? Paquete { get; set; }

    public DateTime? Tdd { get; set; }

    public DateTime? Idox { get; set; }

    public DateTime? Wpx { get; set; }

    public string LlegadaOcurresDeLunesAViernes { get; set; }

    public string LlegadaOcurresSabatino { get; set; }
}
