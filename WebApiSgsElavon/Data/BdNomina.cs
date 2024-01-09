using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class BdNomina
{
    public int? Year { get; set; }

    public int? Month { get; set; }

    public int? Secuencia { get; set; }

    public string Curp { get; set; }

    public string Nombre { get; set; }

    public string Puesto { get; set; }

    public string Centro { get; set; }

    public int? IdRegion { get; set; }

    public int? IdPlaza { get; set; }

    public int? IdProducto { get; set; }

    public int? IdProyecto { get; set; }

    public decimal? TotConViaticos { get; set; }

    public decimal? TotSinViaticos { get; set; }

    public DateOnly? Antiguedad { get; set; }

    public DateOnly? FecBaja { get; set; }

    public decimal? Sueldo { get; set; }

    public decimal? Vales { get; set; }

    public decimal? Prestaciones { get; set; }

    public decimal? Bonos { get; set; }

    public decimal? Guardias { get; set; }

    public decimal? Finiquito { get; set; }

    public decimal? Descuentos { get; set; }

    public decimal? Comisiones { get; set; }

    public decimal? EsquemaTpv { get; set; }

    public decimal? Vacaciones { get; set; }

    public decimal? ViaticosNoComp { get; set; }

    public decimal? ImpSobreNomina { get; set; }

    public decimal? ImpSar { get; set; }

    public decimal? AyudaComida { get; set; }

    public decimal? AyudaTransporte { get; set; }

    public decimal? Ptu { get; set; }
}
