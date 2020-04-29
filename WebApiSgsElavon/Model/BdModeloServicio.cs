using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_MODELO_SERVICIO")]
    public partial class BdModeloServicio
    {
        [Column("ID_MODELO_SERVICIO")]
        public int IdModeloServicio { get; set; }
        [Column("ID_MODELO")]
        public int IdModelo { get; set; }
        [Column("ID_SERVICIO")]
        public int IdServicio { get; set; }
        [Column("ID_CLIENTE")]
        public int IdCliente { get; set; }
        [Column("IS_INSTALACION")]
        public int? IsInstalacion { get; set; }
        [Column("IS_SUSTITUCION")]
        public int? IsSustitucion { get; set; }
        [Column("IS_RETIRO")]
        public int? IsRetiro { get; set; }
        [Column("IS_CHECKED")]
        [StringLength(50)]
        public string IsChecked { get; set; }
    }
}
