using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.Data;

public partial class BdInsumosAltum
{
    public int IdInsumosAlta { get; set; }

    public int? IdInsumo { get; set; }

    public int? Cantidades { get; set; }

    public int? IdCliente { get; set; }

    public int? IdSolicitudRecoleccion { get; set; }

    public string PosicionInventario { get; set; }

    public string NoTarima { get; set; }

    public int? IdResponsable { get; set; }

    public int? IsNullCliente { get; set; }

    public int? IsProcesada { get; set; }

    public int? IdUsuarioAlta { get; set; }

    public DateTime? FecAlta { get; set; }

    public string Status { get; set; }
}
