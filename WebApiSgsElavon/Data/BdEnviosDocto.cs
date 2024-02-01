using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.Data;

public partial class BdEnviosDocto
{
    public int IdEnvioDoctos { get; set; }

    public int? IdTipoResponsableOrigen { get; set; }

    public int? IdResponsableOrigen { get; set; }

    public int? IdTipoResponsableDestino { get; set; }

    public int? IdResponsableDestino { get; set; }

    public int? IdServicioMensajeria { get; set; }

    public string NoGuia { get; set; }

    public decimal? Costo { get; set; }

    public int? IdUrgenciaEnvio { get; set; }

    public DateTime? FecEnvio { get; set; }

    public DateTime? FecRecepcion { get; set; }

    public int? IdStatusEnvio { get; set; }

    public int? IdUsuarioAlta { get; set; }

    public DateTime? FecAlta { get; set; }

    public string Status { get; set; }
}
