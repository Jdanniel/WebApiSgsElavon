using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.Data;

public partial class BdAltaCancelacionArMasivo
{
    public int IdAlta { get; set; }

    public int? IdAr { get; set; }

    public string Comentario { get; set; }

    public int? IdUsuario { get; set; }

    public string Error { get; set; }

    public string Status { get; set; }

    public int? IdCarga { get; set; }
}
