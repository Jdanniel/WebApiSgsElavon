using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class BdArDiasAtencion
{
    public int IdArDiasAtencion { get; set; }

    public int? IdAr { get; set; }

    public int? Lunes { get; set; }

    public int? Martes { get; set; }

    public int? Miercoles { get; set; }

    public int? Jueves { get; set; }

    public int? Viernes { get; set; }

    public int? Sabado { get; set; }

    public int? Domingo { get; set; }

    public int? IdUsuarioAlta { get; set; }

    public DateTime? FecAlta { get; set; }
}
