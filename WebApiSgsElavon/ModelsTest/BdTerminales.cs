using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.ModelsTest
{
    public partial class BdTerminales
    {
        public int IdTerminal { get; set; }
        public string DescTerminal { get; set; }
        public string Descripcion { get; set; }
        public string Version { get; set; }
        public string AppRoute { get; set; }
        public string DocRoute { get; set; }
        public string WebRoute { get; set; }
        public string Status { get; set; }
    }
}
