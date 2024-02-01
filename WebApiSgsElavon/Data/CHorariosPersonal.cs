using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.Data;

public partial class CHorariosPersonal
{
    public int IdHorarioPersonal { get; set; }

    public string DescHorarioPersonal { get; set; }

    public TimeOnly? Inicio { get; set; }

    public TimeOnly? Termino { get; set; }

    public string Status { get; set; }

    public DateTime? FechaAlta { get; set; }

    public int? IdUsuarioAlta { get; set; }
}
