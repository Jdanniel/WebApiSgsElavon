using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_BITACORA_PROCEDURE")]
    public partial class BdBitacoraProcedure
    {
        [Column("ID_BITACORA_PROCEDURE")]
        public int IdBitacoraProcedure { get; set; }
        [Column("DESCRIPCION")]
        public string Descripcion { get; set; }
        [Column("FECHA_USO", TypeName = "datetime")]
        public DateTime? FechaUso { get; set; }
        [Column("ID_USUARIO")]
        public int? IdUsuario { get; set; }
    }
}
