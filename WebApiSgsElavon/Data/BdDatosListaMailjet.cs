using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.Data;

public partial class BdDatosListaMailjet
{
    public int IdDatoListaMailjet { get; set; }

    public int? IdListaMailjet { get; set; }

    public int? IdArchivoContacto { get; set; }

    public string NombreLista { get; set; }

    public int? IdUsuarioAlta { get; set; }

    public DateTime? FecAlta { get; set; }

    public int? IdTipoLista { get; set; }
}
