using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("C_ZONA_ATENCION_SANTANDER")]
    public partial class CZonaAtencionSantander
    {
        [Key]
        [Column("ID_ZONA_ATENCION")]
        public int IdZonaAtencion { get; set; }
        [Column("ID_ZONA")]
        public int IdZona { get; set; }
        [Column("ID_REGION")]
        public int IdRegion { get; set; }
        [Column("CENTRO_SERVICIO")]
        [StringLength(200)]
        public string CentroServicio { get; set; }
        [Column("ESTADO")]
        [StringLength(150)]
        public string Estado { get; set; }
        [Column("REGION")]
        [StringLength(150)]
        public string Region { get; set; }
        [Column("RESPONSABLE")]
        [StringLength(150)]
        public string Responsable { get; set; }
        [Column("ZONA_MF")]
        public int? ZonaMf { get; set; }
    }
}
