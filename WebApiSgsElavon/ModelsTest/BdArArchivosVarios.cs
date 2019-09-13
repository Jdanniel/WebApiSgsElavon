using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.ModelsTest
{
    public partial class BdArArchivosVarios
    {
        public int IdArArchivoVarios { get; set; }
        public int IdAr { get; set; }
        public string NombreArchivoSistema { get; set; }
        public string NombreArchivoUsuario { get; set; }
        public string Ruta { get; set; }
        public int? IdTipoArchivo { get; set; }
        public int? IdUsuarioAlta { get; set; }
        public DateTime? FechaAlta { get; set; }
        public int? IdUsuarioStatus { get; set; }
        public DateTime? FechaStatus { get; set; }
        public string Status { get; set; }
    }
}
