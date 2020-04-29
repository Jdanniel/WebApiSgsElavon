using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("C_SERVICIOS_DOBLES")]
    public partial class CServiciosDobles
    {
        [Column("ID_SERVICIO_DOBLE")]
        public int IdServicioDoble { get; set; }
        [Column("ID_FALLA")]
        public int? IdFalla { get; set; }
        [Column("ID_SERVICIO")]
        public int? IdServicio { get; set; }
        [Column("OUTBLUE")]
        public int? Outblue { get; set; }
        [Column("ROLLOS_PRODUCTIVO")]
        public int? RollosProductivo { get; set; }
    }
}
