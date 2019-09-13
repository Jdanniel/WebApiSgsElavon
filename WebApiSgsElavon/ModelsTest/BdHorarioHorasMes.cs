using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.ModelsTest
{
    public partial class BdHorarioHorasMes
    {
        public int IdHorarioHorasMes { get; set; }
        public int IdHorario { get; set; }
        public int Mes { get; set; }
        public int Anio { get; set; }
        public int? HorasMes { get; set; }
        public DateTime? FecAlta { get; set; }

        public virtual CHorarios IdHorarioNavigation { get; set; }
    }
}
