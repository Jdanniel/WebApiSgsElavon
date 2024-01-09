using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class CHorario
{
    public int IdHorario { get; set; }

    public string DescHorario { get; set; }

    public string Descripcion { get; set; }

    public string Status { get; set; }

    public int? IdUsuarioAlta { get; set; }

    public DateTime? FecAlta { get; set; }

    public virtual ICollection<BdHorarioHorasMe> BdHorarioHorasMes { get; set; } = new List<BdHorarioHorasMe>();

    public virtual ICollection<BdHorarioWeekhour> BdHorarioWeekhours { get; set; } = new List<BdHorarioWeekhour>();

    public virtual ICollection<BdNegocio> BdNegocioIdHorarioAccesoNavigations { get; set; } = new List<BdNegocio>();

    public virtual ICollection<BdNegocio> BdNegocioIdHorarioUptimeNavigations { get; set; } = new List<BdNegocio>();
}
