using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class BdBitacoraTipoCausaCancelacion
{
    public int IdBitacoraTipoCausaCancelacion { get; set; }

    public int? IdCausaCancelacion { get; set; }

    public string DescCausaCancelacionAnterior { get; set; }

    public string DescCausaCancelacionActual { get; set; }

    public string StatusAnterior { get; set; }

    public string StatusActual { get; set; }

    public string IdTipoCanceladoAnterior { get; set; }

    public string IdTipoCanceladoActual { get; set; }

    public DateTime? FecAlta { get; set; }

    public int? UsuariosAlta { get; set; }
}
