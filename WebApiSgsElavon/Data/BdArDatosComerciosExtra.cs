using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.Data;

public partial class BdArDatosComerciosExtra
{
    public int IdArDatoComercioExtra { get; set; }

    public int? IdAr { get; set; }

    public string NoAr { get; set; }

    public string Telefono { get; set; }

    public string PersonaAtendera { get; set; }

    public string ProveedorAtendera { get; set; }
}
