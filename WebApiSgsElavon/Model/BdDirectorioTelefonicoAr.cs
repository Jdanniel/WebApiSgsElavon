using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_DIRECTORIO_TELEFONICO_AR")]
    public partial class BdDirectorioTelefonicoAr
    {
        [Column("ID_DIRECTORIO_TELEFONICO_AR")]
        public int IdDirectorioTelefonicoAr { get; set; }
        [Column("TELEFONO")]
        public string Telefono { get; set; }
        [Column("ID_AR")]
        public int? IdAr { get; set; }
        [Column("USUARIO_ALTA")]
        public int? UsuarioAlta { get; set; }
        [Column("FECHA_ALTA", TypeName = "datetime")]
        public DateTime? FechaAlta { get; set; }
    }
}
