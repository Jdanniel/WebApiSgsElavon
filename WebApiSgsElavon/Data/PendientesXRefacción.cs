using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class PendientesXRefacción
{
    public int? Anio { get; set; }

    public int? Mes { get; set; }

    public int? Dia { get; set; }

    public int IdAr { get; set; }

    public int? IdProducto { get; set; }

    public string DescProducto { get; set; }

    public int IdCliente { get; set; }

    public string DescCliente { get; set; }

    public int? IdTipoServicio { get; set; }

    public string DescTipoServicio { get; set; }

    public int? VecesPendienteXRefaccion { get; set; }

    public int DuracionPendienteXRefaccion { get; set; }

    public int? VecesPendienteXInsumo { get; set; }

    public int DuracionPendienteXInsumo { get; set; }

    public int? VecesPendienteXTerminal { get; set; }

    public int DuracionPendienteXTerminal { get; set; }

    public int? VecesPendienteXSp { get; set; }

    public int DuracionPendienteXSp { get; set; }

    public int? IdAlmacen { get; set; }

    public string Almacen { get; set; }
}
