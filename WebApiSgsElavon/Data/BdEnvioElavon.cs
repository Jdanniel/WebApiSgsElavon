﻿using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.Data;

public partial class BdEnvioElavon
{
    public int IdEnvioElavon { get; set; }

    public string XmlData { get; set; }

    public DateTime? FecAlta { get; set; }

    public int? IsProcesado { get; set; }

    public string NombreArchivo { get; set; }
}
