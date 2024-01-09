using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class HistoricoBbva
{
    public int IdHistorico { get; set; }

    public string NoSerieSale { get; set; }

    public DateOnly? FechaActualizacion { get; set; }
}
