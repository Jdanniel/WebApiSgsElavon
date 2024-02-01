using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.Data;

public partial class CWeekhour
{
    public int IdWeekhour { get; set; }

    public string DescWeekhour { get; set; }

    public int? Weekday { get; set; }

    public string StartTime { get; set; }

    public string EndTime { get; set; }

    public string Status { get; set; }

    public virtual ICollection<BdHorarioWeekhour> BdHorarioWeekhours { get; set; } = new List<BdHorarioWeekhour>();
}
