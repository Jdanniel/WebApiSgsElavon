using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_TERMINALES")]
    public partial class BdTerminales
    {
        [Column("ID_TERMINAL")]
        public int IdTerminal { get; set; }
        [Column("DESC_TERMINAL")]
        [StringLength(255)]
        public string DescTerminal { get; set; }
        [Column("DESCRIPCION")]
        [StringLength(255)]
        public string Descripcion { get; set; }
        [Column("VERSION")]
        [StringLength(255)]
        public string Version { get; set; }
        [Column("APP_ROUTE")]
        [StringLength(255)]
        public string AppRoute { get; set; }
        [Column("DOC_ROUTE")]
        [StringLength(255)]
        public string DocRoute { get; set; }
        [Column("WEB_ROUTE")]
        [StringLength(255)]
        public string WebRoute { get; set; }
        [Column("STATUS")]
        [StringLength(20)]
        public string Status { get; set; }
    }
}
