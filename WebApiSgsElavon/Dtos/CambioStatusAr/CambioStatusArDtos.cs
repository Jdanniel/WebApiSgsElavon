﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace WebApiSgsElavon.Dtos.CambioStatusAr
{
    public class CambioStatusArDtos
    {
        [JsonPropertyName("ID_CAMBIO_STATUS_AR")]
        public int IdCambioStatusAr { get; set; }
        [JsonPropertyName("ID_STATUS_AR_INI")]
        public int IdStatusArIni { get; set; }
        [JsonPropertyName("ID_STATUS_AR_FIN")]
        public int IdStatusArFin { get; set; }
    }
}
