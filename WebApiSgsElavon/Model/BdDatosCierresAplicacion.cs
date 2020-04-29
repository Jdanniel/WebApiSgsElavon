using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_DATOS_CIERRES_APLICACION")]
    public partial class BdDatosCierresAplicacion
    {
        [Column("ID_DATO_CIERRE_APLICACION")]
        public int IdDatoCierreAplicacion { get; set; }
        [Column("DATOS")]
        public string Datos { get; set; }
        [Column("TIPO_CIERRE")]
        public string TipoCierre { get; set; }
        [Column("FECHA_CARGA", TypeName = "datetime")]
        public DateTime? FechaCarga { get; set; }
        [Column("ID_USUARIO")]
        public int? IdUsuario { get; set; }
        [Column("ID_AR")]
        public int? IdAr { get; set; }
    }
}
