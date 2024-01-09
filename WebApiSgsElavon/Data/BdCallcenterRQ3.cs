using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class BdCallcenterRQ3
{
    public int IdRespuestaQ3 { get; set; }

    public int? IdCallCenterSerguimiento { get; set; }

    public string AtiendeLlamada { get; set; }

    public string Respuesta1 { get; set; }

    public string Nota1 { get; set; }

    public int? CodRechazo1 { get; set; }

    public string Respuesta2 { get; set; }

    public string Nota2 { get; set; }

    public int? CodRechazo2 { get; set; }

    public string Respuesta3 { get; set; }

    public string Nota3 { get; set; }

    public int? CodRechazo3 { get; set; }

    public string Respuesta4 { get; set; }

    public string Nota4 { get; set; }

    public string Respuesta5 { get; set; }

    public DateTime? HorarioCita { get; set; }

    public string Nota5 { get; set; }

    public int? CodRechazo5 { get; set; }

    public string Respuesta6 { get; set; }

    public string Nota6 { get; set; }

    public string IdLlamadaContacto { get; set; }

    public string IdLlamadaElavon { get; set; }

    public string NombreRechazaElavon { get; set; }

    public string NombreAtenderaServicio { get; set; }

    public string TelefonoAtenderaServicio { get; set; }

    public DateTime? FecCreacion { get; set; }
}
