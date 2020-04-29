using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_CALLCENTER_R_Q9")]
    public partial class BdCallcenterRQ9
    {
        [Key]
        [Column("ID_RESPUESTA_Q9")]
        public int IdRespuestaQ9 { get; set; }
        [Column("ID_CALL_CENTER_SEGUIMIENTO")]
        public int? IdCallCenterSeguimiento { get; set; }
        [Column("ATIENDE_LLAMADA")]
        [StringLength(100)]
        public string AtiendeLlamada { get; set; }
        [Column("RESPUESTA_1")]
        [StringLength(2)]
        public string Respuesta1 { get; set; }
        [Column("NOTA_1", TypeName = "text")]
        public string Nota1 { get; set; }
        [Column("COD_RECHAZO_1")]
        public int? CodRechazo1 { get; set; }
        [Column("RESPUESTA_2")]
        [StringLength(2)]
        public string Respuesta2 { get; set; }
        [Column("NOTA_2", TypeName = "text")]
        public string Nota2 { get; set; }
        [Column("COD_RECHAZO_2")]
        public int? CodRechazo2 { get; set; }
        [Column("RESPUESTA_3")]
        [StringLength(2)]
        public string Respuesta3 { get; set; }
        [Column("NOTA_3", TypeName = "text")]
        public string Nota3 { get; set; }
        [Column("COD_RECHAZO_3")]
        public int? CodRechazo3 { get; set; }
        [Column("RESPUESTA_4")]
        [StringLength(2)]
        public string Respuesta4 { get; set; }
        [Column("NOTA_4", TypeName = "text")]
        public string Nota4 { get; set; }
        [Column("COD_RECHAZO_4")]
        public int? CodRechazo4 { get; set; }
        [Column("RESPUESTA_5")]
        [StringLength(22)]
        public string Respuesta5 { get; set; }
        [Column("NOTA_5", TypeName = "text")]
        public string Nota5 { get; set; }
        [Column("COD_RECHAZO_5")]
        public int? CodRechazo5 { get; set; }
        [Column("RESPUESTA_6")]
        [StringLength(10)]
        public string Respuesta6 { get; set; }
        [Column("NOTA_6", TypeName = "text")]
        public string Nota6 { get; set; }
        [Column("RESPUESTA_7")]
        [StringLength(2)]
        public string Respuesta7 { get; set; }
        [Column("HORARIO_CITA", TypeName = "datetime")]
        public DateTime? HorarioCita { get; set; }
        [Column("NOTA_7", TypeName = "text")]
        public string Nota7 { get; set; }
        [Column("COD_RECHAZO_7")]
        public int? CodRechazo7 { get; set; }
        [Column("RESPUESTA_8")]
        [StringLength(2)]
        public string Respuesta8 { get; set; }
        [Column("NOTA_8", TypeName = "text")]
        public string Nota8 { get; set; }
        [Column("ID_LLAMADA_CONTACTO")]
        [StringLength(100)]
        public string IdLlamadaContacto { get; set; }
        [Column("ID_LLAMADA_ELAVON")]
        [StringLength(100)]
        public string IdLlamadaElavon { get; set; }
        [Column("NOMBRE_ATENDERA_SERVICIO")]
        [StringLength(100)]
        public string NombreAtenderaServicio { get; set; }
        [Column("TELEFONO_ATENDERA_SERVICIO")]
        [StringLength(10)]
        public string TelefonoAtenderaServicio { get; set; }
        [Column("FEC_CREACION", TypeName = "datetime")]
        public DateTime? FecCreacion { get; set; }
    }
}
