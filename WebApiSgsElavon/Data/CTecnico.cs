﻿using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.Data;

public partial class CTecnico
{
    public int IdTecnico { get; set; }

    public int? IdUsuario { get; set; }

    public string Nombre { get; set; }

    public string Paterno { get; set; }

    public string Materno { get; set; }

    public string Status { get; set; }

    public int IdUsuarioAlta { get; set; }

    public DateTime FecAlta { get; set; }
}
