using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class BdErrorUnidadesDaniada
{
    public int IdErrorUnidadesDaniadas { get; set; }

    public string NoSerie { get; set; }

    public string Mensaje { get; set; }

    public int? Status { get; set; }

    public int? IdUsuarioAlta { get; set; }

    public DateTime? FecAlta { get; set; }
}
