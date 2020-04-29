using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_FALLA_CON_FALLA_ENCONTRADA")]
    public partial class BdFallaConFallaEncontrada
    {
        [Key]
        [Column("ID_FALLA_FALLA_ENCONTRADA")]
        public int IdFallaFallaEncontrada { get; set; }
        [Column("ID_FALLA_PADRE")]
        public int? IdFallaPadre { get; set; }
        [Column("ID_FALLA_HIJO")]
        public int? IdFallaHijo { get; set; }
        [Column("ID_CLIENTE")]
        public int? IdCliente { get; set; }
        [Column("STATUS")]
        [StringLength(25)]
        public string Status { get; set; }
    }
}
