using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.ModelsTest
{
    public partial class CElavonSantanderServicios
    {
        public int IdElavon { get; set; }
        public string DescServicioElavon { get; set; }
        public string SubtipoServicio { get; set; }
        public int? IdServicio { get; set; }
        public string Vip { get; set; }
        public int? IdSegmento { get; set; }
        public int? IdFalla { get; set; }
        public string ServiciosSgs { get; set; }
        public int? IsReparado { get; set; }
    }
}
