using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class BdServiciosFallasProyEspeciale
{
    public int Id { get; set; }

    public int? IdProyectoEspecial { get; set; }

    public int? IdServicio { get; set; }

    public int? IdFalla { get; set; }

    public string Mensaje { get; set; }

    public string Status { get; set; }

    public DateTime? FecAlta { get; set; }

    public string IdUsuario { get; set; }
}
