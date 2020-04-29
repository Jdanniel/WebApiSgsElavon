using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("C_PROYECTOS_PMO")]
    public partial class CProyectosPmo
    {
        [Key]
        [Column("ID_PROYECTO_PMO")]
        public int IdProyectoPmo { get; set; }
        [Column("ID_CLIENTE")]
        public int? IdCliente { get; set; }
        [Column("ID_USUARIO")]
        public int? IdUsuario { get; set; }
        [Column("PERFIL")]
        [StringLength(10)]
        public string Perfil { get; set; }
        [Column("STATUS")]
        [StringLength(10)]
        public string Status { get; set; }
    }
}
