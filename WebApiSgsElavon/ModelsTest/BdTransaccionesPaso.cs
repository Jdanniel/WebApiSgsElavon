using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.ModelsTest
{
    public partial class BdTransaccionesPaso
    {
        public int IdTransaccionesPaso { get; set; }
        public int IdCarga { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }
        public int NoAfiliacion { get; set; }
        public int ApprovedcCount { get; set; }
        public int Declinedcount { get; set; }
        public int? IsError { get; set; }
        public string DescError { get; set; }
    }
}
