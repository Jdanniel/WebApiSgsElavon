﻿using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.Data;

public partial class BdBitacoraError
{
    public int IdError { get; set; }

    public string DescError { get; set; }

    public int? IdUsuarioAlta { get; set; }

    public DateTime? FecAlta { get; set; }
}
