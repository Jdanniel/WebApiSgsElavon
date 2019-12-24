using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiSgsElavon.Entities.Requests
{
    public class AgregarRechazarOdtRequest
    {
        public int ID_AR { get; set; }
        public int ID_USUARIO { get; set; }
        public int ID_STATUS_AR { get; set; }
    }
}
