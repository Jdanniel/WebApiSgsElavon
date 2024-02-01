using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.Data;

public partial class BdBitacoraSubServicio
{
    public int IdBitacoraSubServicios { get; set; }

    public int? IdFalla { get; set; }

    public string DescFallaAnterior { get; set; }

    public string DescFallaActual { get; set; }

    public string StatusAnterior { get; set; }

    public string StatusActual { get; set; }

    public int? IsDowntimeAnterior { get; set; }

    public int? IsDowntimeActual { get; set; }

    public DateTime? FecAlta { get; set; }

    public int? IdUsuariosAlta { get; set; }
}
