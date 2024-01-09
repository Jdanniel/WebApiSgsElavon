using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class CostoIngeniero
{
    public int IdUsuario { get; set; }

    public string Curp { get; set; }

    public string Nombre { get; set; }

    public string Region { get; set; }

    public string Zona { get; set; }

    public double? Fijo { get; set; }

    public double? Transporte { get; set; }

    public double? Variable { get; set; }

    public double? Total { get; set; }

    public int? Atm { get; set; }

    public int? Modem { get; set; }

    public int? Otros { get; set; }

    public int? Seguridad { get; set; }

    public int? Turnos { get; set; }

    public int? Tpv { get; set; }

    public int? TresM { get; set; }

    public int? TotServicios { get; set; }

    public decimal? VAtm { get; set; }

    public decimal? VModems { get; set; }

    public decimal? VOtros { get; set; }

    public decimal? VSeguridad { get; set; }

    public decimal? VTurnos { get; set; }

    public decimal? VTpv { get; set; }

    public decimal? V3m { get; set; }

    public decimal? VSinProducto { get; set; }

    public decimal? VTotal { get; set; }

    public double? VAvion { get; set; }

    public double? VGas { get; set; }

    public decimal Movil { get; set; }

    public double? Staff { get; set; }

    public double? RefaccionesAtm { get; set; }

    public double? RefaccionesModems { get; set; }

    public double? RefaccionesOtros { get; set; }

    public double? RefaccionesSeguridad { get; set; }

    public double? RefaccionesTurnos { get; set; }

    public double? RefaccionesTpv { get; set; }

    public double? Refacciones3m { get; set; }

    public int? Usadas { get; set; }

    public double? UsadasAtm { get; set; }

    public double? UsadasModems { get; set; }

    public double? UsadasOtros { get; set; }

    public double? UsadasSeguridad { get; set; }

    public double? UsadasTurnos { get; set; }

    public double? UsadasTpv { get; set; }

    public double? Usadas3m { get; set; }

    public double? Envios { get; set; }

    public double? Laboratorio { get; set; }

    public string Vehiculo { get; set; }

    public double? RentaVehiculo { get; set; }

    public double? ManttoVehiculo { get; set; }

    public double? IngServAtm { get; set; }

    public double? IngServModem { get; set; }

    public double? IngServOtros { get; set; }

    public double? IngServSeguridad { get; set; }

    public double? IngServTnm { get; set; }

    public double? IngServTpv { get; set; }

    public double? IngServ3m { get; set; }
}
