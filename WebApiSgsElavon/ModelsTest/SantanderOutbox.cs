using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.ModelsTest
{
    public partial class SantanderOutbox
    {
        public int IdSantanderOutbox { get; set; }
        public int IdAr { get; set; }
        public int IdTipoOutboxSantander { get; set; }
        public string NameFile { get; set; }
        public DateTime? FechaEnvio { get; set; }
        public string Status { get; set; }
    }
}
