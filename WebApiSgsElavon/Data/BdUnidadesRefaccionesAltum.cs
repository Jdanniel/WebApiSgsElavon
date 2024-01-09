using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class BdUnidadesRefaccionesAltum
{
    public int IdUnidadRefaccionAlta { get; set; }

    public int? IdParent { get; set; }

    public int IdCliente { get; set; }

    public int? IdSolicitudRecoleccion { get; set; }

    public int? IdProducto { get; set; }

    public int? IsNueva { get; set; }

    public int IdMarca { get; set; }

    public int IdModelo { get; set; }

    public string NoSerie { get; set; }

    public string NoInventario { get; set; }

    public int? IdSim { get; set; }

    public string NoImei { get; set; }

    public string NoSim { get; set; }

    public string NoEquipo { get; set; }

    public int? IdTipoResponsable { get; set; }

    public int? IdResponsable { get; set; }

    public int? IdLlave { get; set; }

    public int? IdSoftware { get; set; }

    public string PosicionInventario { get; set; }

    public int? IsRetiro { get; set; }

    public int? IsDaniada { get; set; }

    public decimal? Costo { get; set; }

    public int? IdMoneda { get; set; }

    public int IdStatusUnidad { get; set; }

    public int? IsPropiedadCliente { get; set; }

    public int? IsListaNoSerieDuplicada { get; set; }

    public int? IsNoSerieDuplicada { get; set; }

    public string IsDatoNulo { get; set; }

    public int? IsProcesada { get; set; }

    public int? NecesitaCostoOIdMoneda { get; set; }
}
