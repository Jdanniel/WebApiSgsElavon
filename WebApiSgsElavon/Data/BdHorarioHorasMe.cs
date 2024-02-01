using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.Data;

public partial class BdHorarioHorasMe
{
    public int IdHorarioHorasMes { get; set; }

    public int IdHorario { get; set; }

    public int Mes { get; set; }

    public int Anio { get; set; }

    public int? HorasMes { get; set; }

    public DateTime? FecAlta { get; set; }

    public virtual CHorario IdHorarioNavigation { get; set; }
}
