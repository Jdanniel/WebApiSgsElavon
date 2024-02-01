using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.Data;

public partial class CSolucione
{
    public int IdSolucion { get; set; }

    public string DescSolucion { get; set; }

    public string Descripcion { get; set; }

    public int? IdCliente { get; set; }

    public string Clave { get; set; }

    public int? IsExito { get; set; }

    public string Status { get; set; }

    public int? IdUsuarioAlta { get; set; }

    public DateTime? FecAlta { get; set; }

    public virtual ICollection<BdServicioSolucion> BdServicioSolucions { get; set; } = new List<BdServicioSolucion>();
}
