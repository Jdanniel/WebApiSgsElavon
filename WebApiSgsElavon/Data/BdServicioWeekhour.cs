using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class BdServicioWeekhour
{
    public int IdServicioWeekhour { get; set; }

    public int? IdServicio { get; set; }

    public int? IdWeekhour { get; set; }

    public int? IdUsuarioAlta { get; set; }

    public DateTime? FecAlta { get; set; }
}
