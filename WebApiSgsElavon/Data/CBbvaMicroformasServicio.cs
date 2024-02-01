using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.Data;

public partial class CBbvaMicroformasServicio
{
    public int IdBbva { get; set; }

    public string DesservBbva { get; set; }

    public string TipoServicio { get; set; }

    public string Vim { get; set; }

    public int? IdServicio { get; set; }

    public int? IdSegmento { get; set; }

    public int? IdFalla { get; set; }
}
