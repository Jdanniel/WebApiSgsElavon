﻿using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.Data;

public partial class BdArAccesorio
{
    public int IdArAccesorio { get; set; }

    public int? IdAr { get; set; }

    public string Bateria { get; set; }

    public string Eliminador { get; set; }

    public string Base { get; set; }

    public string Tapa { get; set; }

    public string CableAc { get; set; }

    public string Movimiento { get; set; }
}
