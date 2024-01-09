using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class TempUsuariosActivosGetnet
{
    public int IdUsuario { get; set; }

    public string DescTipoUsuario { get; set; }

    public string Nombre { get; set; }

    public string Paterno { get; set; }

    public string Materno { get; set; }

    public string Username { get; set; }

    public string Email { get; set; }

    public string Status { get; set; }

    public string Proveedor { get; set; }

    public string FecStatusAccesso { get; set; }
}
