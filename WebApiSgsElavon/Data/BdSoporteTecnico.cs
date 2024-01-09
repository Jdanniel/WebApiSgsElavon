using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class BdSoporteTecnico
{
    public int IdSoporteTecnico { get; set; }

    public int? IdAr { get; set; }

    public int? IdTipoSoporteTecnico { get; set; }

    public int? IdStatusArAnt { get; set; }

    public int? IdUsuarioSoporte { get; set; }

    public int? IdUsuarioAlta { get; set; }

    public DateTime? FecAlta { get; set; }

    public int? IdUsuarioConfirm { get; set; }

    public DateTime? FecConfirm { get; set; }

    public int? IsChecked { get; set; }

    public string Status { get; set; }

    public virtual CTipoSoporteTecnico IdTipoSoporteTecnicoNavigation { get; set; }
}
