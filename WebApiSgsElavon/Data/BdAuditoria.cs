using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class BdAuditoria
{
    public int IdAuditoria { get; set; }

    public string DescAuditoria { get; set; }

    public int? IdTipoAuditoria { get; set; }

    public DateTime? FechaInicio { get; set; }

    public DateTime? FechaFin { get; set; }

    public int? IdUsuarioAlta { get; set; }

    public DateTime? FechaAlta { get; set; }

    public string Status { get; set; }

    public int? IdRegion { get; set; }

    public virtual ICollection<BdAuditoriaReporte> BdAuditoriaReportes { get; set; } = new List<BdAuditoriaReporte>();

    public virtual CTipoAuditorium IdTipoAuditoriaNavigation { get; set; }

    public virtual CUsuario IdUsuarioAltaNavigation { get; set; }
}
