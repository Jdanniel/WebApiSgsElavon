using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class CSubrechazo
{
    public int IdSubrechazo { get; set; }

    public string Subrechazo { get; set; }

    public string Status { get; set; }

    public int? UsuarioAlta { get; set; }

    public DateTime? FechaAlta { get; set; }

    public int? Id { get; set; }

    public int? IsProgramado { get; set; }
}
