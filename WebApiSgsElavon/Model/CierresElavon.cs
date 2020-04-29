using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("CIERRES_ELAVON")]
    public partial class CierresElavon
    {
        [Column("id_cierres_elavon")]
        public int IdCierresElavon { get; set; }
        [Column("ODTEXTERNA")]
        public string Odtexterna { get; set; }
        [Column("STATUS_MOV")]
        public string StatusMov { get; set; }
        [Column("ERROR")]
        public string Error { get; set; }
        [Column("FECHA_CIERRE")]
        public string FechaCierre { get; set; }
        [Column("NOMBRE_USUARIO")]
        public string NombreUsuario { get; set; }
        [Column("TIPO_USUARIO")]
        public string TipoUsuario { get; set; }
    }
}
