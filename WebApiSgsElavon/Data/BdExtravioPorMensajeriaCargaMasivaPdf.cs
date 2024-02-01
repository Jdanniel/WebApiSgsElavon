using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.Data;

public partial class BdExtravioPorMensajeriaCargaMasivaPdf
{
    public int IdReparacionCargaPdf { get; set; }

    public string Cadena { get; set; }

    public string Motivo { get; set; }

    public string ArchivoUsuario { get; set; }

    public string ArchivoSistema { get; set; }

    public int? IdUsuarioAlta { get; set; }

    public DateTime? FecAlta { get; set; }

    public string Comentario { get; set; }

    public int? IdStatusUnidad { get; set; }
}
