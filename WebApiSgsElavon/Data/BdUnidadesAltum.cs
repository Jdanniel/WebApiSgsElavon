using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class BdUnidadesAltum
{
    public int IdUnidadAlta { get; set; }

    public int IdCliente { get; set; }

    public int? IdProducto { get; set; }

    public int? IsNueva { get; set; }

    public int? IsDaniada { get; set; }

    public int IdMarca { get; set; }

    public int IdModelo { get; set; }

    public string NoSerie { get; set; }

    public string NoInventario { get; set; }

    public string NoImei { get; set; }

    public string NoSim { get; set; }

    public int? IdCarrier { get; set; }

    public string NoEquipo { get; set; }

    public decimal? Costo { get; set; }

    public int? IdMoneda { get; set; }

    public string FecAlta { get; set; }

    public int? IdTipoResponsable { get; set; }

    public int? IdResponsable { get; set; }

    public string PosicionInventario { get; set; }

    public int? IsProcessed { get; set; }

    public int? UnidadDuplicada { get; set; }

    public int? NoSimDuplicado { get; set; }

    public int? NoImeiDuplicado { get; set; }

    public int? NecesitaNoSim { get; set; }

    public int? DuplicadaEnLista { get; set; }

    public int? NecesitaCarrier { get; set; }

    public int? NoSimIncorrecto { get; set; }

    public int? NecesitaCostoOIdMoneda { get; set; }
}
