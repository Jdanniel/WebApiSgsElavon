using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("SEPOMEX")]
    public partial class Sepomex
    {
        [Column("ID")]
        public int Id { get; set; }
        [Column("d_asenta")]
        [StringLength(255)]
        public string DAsenta { get; set; }
        [Column("d_mnpio")]
        [StringLength(255)]
        public string DMnpio { get; set; }
        [Column("d_estado")]
        public int? DEstado { get; set; }
        [Column("d_ciudad")]
        [StringLength(255)]
        public string DCiudad { get; set; }
        [Column("d_CP")]
        [StringLength(10)]
        public string DCp { get; set; }
        [Column("ID_TIPO_LOCALIDAD")]
        public int? IdTipoLocalidad { get; set; }
    }
}
