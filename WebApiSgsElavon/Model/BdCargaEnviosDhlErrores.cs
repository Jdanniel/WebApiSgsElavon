using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_CARGA_ENVIOS_DHL_ERRORES")]
    public partial class BdCargaEnviosDhlErrores
    {
        [Column("ID_CARGA_ENVIO_DHL_ERROR")]
        public int IdCargaEnvioDhlError { get; set; }
        [Column("ID_CARGA_ENVIO_DHL")]
        public int? IdCargaEnvioDhl { get; set; }
        [Column("NO_GUIA")]
        [StringLength(50)]
        public string NoGuia { get; set; }
        [Column("ERROR")]
        [StringLength(255)]
        public string Error { get; set; }
    }
}
