using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class UnidadesBnmAtm
{
    public int Id { get; set; }

    public int? IdParent { get; set; }

    public int? IdCliente { get; set; }

    public int? IdSolicitudRecoleccion { get; set; }

    public int? IdProducto { get; set; }

    public int? IsNueva { get; set; }

    public int? IdMarca { get; set; }

    public string Modelo { get; set; }

    public int? IdModelo { get; set; }

    public string NoSerie { get; set; }

    public string NoInventario { get; set; }

    public int? IdSim { get; set; }

    public string NoSim { get; set; }

    public string NoImei { get; set; }

    public string NoEquipo { get; set; }

    public int? IdTipoResponsable { get; set; }

    public string NoAfiliacion { get; set; }

    public int? IdResponsable { get; set; }

    public int? IdLlave { get; set; }

    public int? IdSoftware { get; set; }

    public string PosicionInv { get; set; }

    public int? IsRetiro { get; set; }

    public int? IsDaniada { get; set; }

    public int? IdStatusUnidad { get; set; }

    public string Status { get; set; }

    public DateTime? FecAlta { get; set; }

    public int? IdUsuarioAlta { get; set; }

    public int? IsDuplicadoLista { get; set; }

    public int? IsSystema { get; set; }

    public int? IsErrorAfiliacion { get; set; }
}
