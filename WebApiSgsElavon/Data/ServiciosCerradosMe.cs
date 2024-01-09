using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class ServiciosCerradosMe
{
    public int? YearFecCierre { get; set; }

    public int? MonthFecCierre { get; set; }

    public string Producto { get; set; }

    public int IdCliente { get; set; }

    public int? IdTecnico { get; set; }

    public int? IdRegion { get; set; }

    public int? IdPlaza { get; set; }

    public int? IdZona { get; set; }

    public int? YearStatusAr { get; set; }

    public int? MonthStatusAr { get; set; }

    public int? CantAr { get; set; }
}
