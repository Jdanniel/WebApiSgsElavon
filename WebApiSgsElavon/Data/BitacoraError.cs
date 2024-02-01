using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.Data;

public partial class BitacoraError
{
    public int IdError { get; set; }

    public string Modulo { get; set; }

    public string Objeto { get; set; }

    public string Comentario { get; set; }

    public string Ruta { get; set; }

    public string Usuario { get; set; }

    public DateTime? FecAlta { get; set; }
}
