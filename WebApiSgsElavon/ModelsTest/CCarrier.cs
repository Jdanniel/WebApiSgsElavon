using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.ModelsTest
{
    public partial class CCarrier
    {
        public int IdCarrier { get; set; }
        public string DescCarrier { get; set; }
        public string Status { get; set; }
        public int? LetraMin { get; set; }
        public int? LetraMax { get; set; }
        public int? NumMin { get; set; }
        public int? NumMax { get; set; }
        public string Caracter { get; set; }
        public int? CaracterObligatorio { get; set; }
        public int? LongMin { get; set; }
        public int? LongMax { get; set; }
        public int? DigitoVerificador { get; set; }
    }
}
