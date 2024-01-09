using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class TempLicenciasDhl
{
    public int IdUsuario { get; set; }

    public string Nombre { get; set; }

    public string Paterno { get; set; }

    public string Materno { get; set; }

    public string Username { get; set; }

    public string Status { get; set; }

    public string Aplicacion { get; set; }

    public string CostoMensual { get; set; }

    public string Accesos { get; set; }

    public string FecDeUltimoAcceso { get; set; }
}
