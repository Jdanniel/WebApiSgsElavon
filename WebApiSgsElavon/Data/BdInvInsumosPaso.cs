using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class BdInvInsumosPaso
{
    public int IdInsumoPaso { get; set; }

    public int? IdCliente { get; set; }

    public int? IdInsumo { get; set; }

    public int? TotalSistema { get; set; }

    public int? Status { get; set; }

    public int? TotalIng { get; set; }

    public string Comentario { get; set; }

    public int? IdUsuario { get; set; }

    public int? IdAuditoria { get; set; }
}
