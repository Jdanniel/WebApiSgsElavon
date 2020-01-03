using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiSgsElavon.Entities.Requests
{
    public class AceptarRechazarOdtRequest
    {
        public int ID_AR { get; set; }
        public int ID_STATUS_AR { get; set; }
        public int ID_TECNICO { get; set; }
    }
}
