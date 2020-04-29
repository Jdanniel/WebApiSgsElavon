using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_AR_DATOS_COMERCIOS_EXTRA")]
    public partial class BdArDatosComerciosExtra
    {
        [Column("ID_AR_DATO_COMERCIO_EXTRA")]
        public int IdArDatoComercioExtra { get; set; }
        [Column("ID_AR")]
        public int? IdAr { get; set; }
        [Column("NO_AR")]
        [StringLength(255)]
        public string NoAr { get; set; }
        [Column("TELEFONO")]
        [StringLength(255)]
        public string Telefono { get; set; }
        [Column("PERSONA_ATENDERA")]
        public string PersonaAtendera { get; set; }
        [Column("PROVEEDOR_ATENDERA")]
        public string ProveedorAtendera { get; set; }
    }
}
