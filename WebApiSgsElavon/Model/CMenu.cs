using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("C_MENU")]
    public partial class CMenu
    {
        [Key]
        [Column("ID_MENU")]
        public int IdMenu { get; set; }
        [Column("NIVEL")]
        public int? Nivel { get; set; }
        [Column("ID_PARENT")]
        public int? IdParent { get; set; }
        [Column("DES_MENU")]
        [StringLength(50)]
        public string DesMenu { get; set; }
        [Column("DES_NAME")]
        [StringLength(75)]
        public string DesName { get; set; }
        [Column("STATUS")]
        [StringLength(50)]
        public string Status { get; set; }
        [Column("TARGET")]
        [StringLength(50)]
        public string Target { get; set; }
        [Column("IMAGE")]
        [StringLength(50)]
        public string Image { get; set; }
        [Column("HREF")]
        public string Href { get; set; }
        [Column("ORDEN")]
        public int? Orden { get; set; }
        [Column("IS_V2")]
        public int? IsV2 { get; set; }
        [Column("IS_V3")]
        public int? IsV3 { get; set; }
        [Column("NIVEL_V3")]
        public int? NivelV3 { get; set; }
        [Column("ID_PARENT_V3")]
        public int? IdParentV3 { get; set; }
        [Column("TARGET_V3")]
        [StringLength(50)]
        public string TargetV3 { get; set; }
        [Column("HREF_V3")]
        public string HrefV3 { get; set; }
        [Column("ORDEN_V3")]
        public int? OrdenV3 { get; set; }
    }
}
