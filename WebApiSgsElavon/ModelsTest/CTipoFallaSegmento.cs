﻿using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.ModelsTest
{
    public partial class CTipoFallaSegmento
    {
        public int IdTipoFallaSegmento { get; set; }
        public int? IdCliente { get; set; }
        public int? IdSegmento { get; set; }
        public int? IdTipoFalla { get; set; }
    }
}
