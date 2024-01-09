using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class BdInsumo
{
    public int IdBdInsumo { get; set; }

    public int? IdCliente { get; set; }

    public int? IdSolicitudRecoleccion { get; set; }

    public int? IdInsumo { get; set; }

    public int? Cantidad { get; set; }

    public int? IdTipoResponsable { get; set; }

    public int? IdResponsable { get; set; }

    public int? IdStatusInsumo { get; set; }

    public int? IdItemsSolicitudAlmacen { get; set; }

    public string Status { get; set; }

    public DateTime? FecAlta { get; set; }

    public string NoTarima { get; set; }

    public string PosicionInventario { get; set; }

    public int? IdUsuarioAlta { get; set; }

    public int? IdOrdenCompra { get; set; }
}
