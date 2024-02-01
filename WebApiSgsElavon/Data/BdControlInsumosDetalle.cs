using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.Data;

public partial class BdControlInsumosDetalle
{
    public int IdControlInsumosDetalle { get; set; }

    public int IdSolicitudAlmacen { get; set; }

    public int IdCliente { get; set; }

    public int IdInsumo { get; set; }

    public int Cantidad { get; set; }

    public int IdTipoReponsable { get; set; }

    public int IdResponsable { get; set; }

    public int IdAlmacen { get; set; }

    public int Status { get; set; }

    public virtual CTipoResponsable IdTipoReponsableNavigation { get; set; }
}
