using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class CTipoCalculoUptime
{
    public int IdTipoCalculoUptime { get; set; }

    public string DescTipoCalculoUptime { get; set; }

    public string Descripcion { get; set; }

    public string Status { get; set; }

    public virtual ICollection<CCliente> CClientes { get; set; } = new List<CCliente>();
}
