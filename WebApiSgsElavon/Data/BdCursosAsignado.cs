using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.Data;

public partial class BdCursosAsignado
{
    public int IdCursoAsignado { get; set; }

    public int? IdCursos { get; set; }

    public int? IdUsuario { get; set; }

    public string Calificacion { get; set; }

    public int? IdUsuarioAlta { get; set; }

    public DateTime? FecAlta { get; set; }

    public string Status { get; set; }
}
