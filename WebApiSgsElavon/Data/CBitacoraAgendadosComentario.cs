using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class CBitacoraAgendadosComentario
{
    public int IdBitacoraAgendadosComentarios { get; set; }

    public string Comentario { get; set; }

    public int? IdCliente { get; set; }

    public string Status { get; set; }

    public int? IdUsuarioAlta { get; set; }

    public DateTime? FecAlta { get; set; }
}
