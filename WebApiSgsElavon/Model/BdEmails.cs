using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_EMAILS")]
    public partial class BdEmails
    {
        [Key]
        [Column("ID_EMAIL")]
        public int IdEmail { get; set; }
        [Column("DESC_EMAIL")]
        [StringLength(255)]
        public string DescEmail { get; set; }
        [Column("EMAIL_FROM")]
        [StringLength(255)]
        public string EmailFrom { get; set; }
        [Column("EMAIL_TO_USER")]
        public int? EmailToUser { get; set; }
        [Column("EMAIL_TO")]
        [StringLength(4000)]
        public string EmailTo { get; set; }
        [Column("EMAIL_SUBJECT")]
        [StringLength(255)]
        public string EmailSubject { get; set; }
        [Column("EMAIL_BODYTYPE")]
        [StringLength(20)]
        public string EmailBodytype { get; set; }
        [Column("EMAIL_BODY")]
        public string EmailBody { get; set; }
        [Column("ATTACHMENT")]
        [StringLength(1000)]
        public string Attachment { get; set; }
        [Column("DESC_ERROR")]
        [StringLength(50)]
        public string DescError { get; set; }
        [Column("STATUS")]
        [StringLength(10)]
        public string Status { get; set; }
        [Column("ID_USUARIO_ALTA")]
        [StringLength(10)]
        public string IdUsuarioAlta { get; set; }
        [Column("FEC_ALTA", TypeName = "smalldatetime")]
        public DateTime? FecAlta { get; set; }
        [Column("FEC_ENVIO", TypeName = "smalldatetime")]
        public DateTime? FecEnvio { get; set; }
    }
}
