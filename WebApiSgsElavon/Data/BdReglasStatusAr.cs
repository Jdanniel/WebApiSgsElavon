using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.Data;

public partial class BdReglasStatusAr
{
    public int IdReglaStatusAr { get; set; }

    public int IdClienteProductoStatusAr { get; set; }

    public int Minutos { get; set; }

    public int IdOperador { get; set; }

    public int IdTiempoReferencia { get; set; }

    public int IdTiempoMedicion { get; set; }

    public int? Prioridad { get; set; }

    public string Status { get; set; }

    public DateTime FecAlta { get; set; }

    public int IdUsuarioAlta { get; set; }

    public virtual BdClienteProductoStatusAr IdClienteProductoStatusArNavigation { get; set; }
}
