﻿using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.Data;

public partial class CStatusJuntum
{
    public int IdStatusJunta { get; set; }

    public string StatusJunta { get; set; }

    public int? IdUsuarioAlta { get; set; }

    public DateTime? FecAlta { get; set; }

    public string Status { get; set; }

    public string ColorRgb { get; set; }

    public int? IsAuto { get; set; }
}
