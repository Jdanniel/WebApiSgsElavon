using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class BdCargaEnviosDhlPaso
{
    public int IdCargaEnvioDhl { get; set; }

    public int? IdCarga { get; set; }

    public string NoGuia { get; set; }

    public string NoReferencia { get; set; }

    public string Producto { get; set; }

    public string Org { get; set; }

    public string Des { get; set; }

    public int? Pza { get; set; }

    public decimal? Kilos { get; set; }

    public DateTime? FecEnvio { get; set; }

    public string NoFactura { get; set; }

    public decimal? Fletes { get; set; }

    public decimal? Seguro { get; set; }

    public decimal? Ff { get; set; }

    public int? Ye { get; set; }

    public decimal? Oo { get; set; }

    public decimal? Descuento { get; set; }

    public decimal? ImpIva { get; set; }

    public decimal? ImporteNeto { get; set; }

    public string ZonaProd { get; set; }

    public decimal? Iva { get; set; }

    public string Moneda { get; set; }

    public string Remitente { get; set; }

    public string Destinatario { get; set; }

    public string Proyecto { get; set; }

    public string Region { get; set; }

    public int? IdUsuario { get; set; }

    public DateTime? FecAlta { get; set; }

    public int? IsProcesado { get; set; }
}
